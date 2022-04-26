using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace YelpApp_v1
{
    public partial class Form2 : Form
    {
        string business_id;
        string tip_date;
        string name;
        Form1 main_set;

        public Form2(Form1 main)
        {
            InitializeComponent();
            main_set = main;
            DataGridViewRow row = main.businessGrid.SelectedRows[0];
            string name = row.Cells["name_col"].Value.ToString();
            string address = row.Cells["address_col"].Value.ToString();
            string sqlStr = "INSERT INTO Users(userid, username, signed_up, useful, cool, funny, fans_count, avg_stars, tip_count) VALUES('PROFILE', 'TEST', '03-28-2022', 0, 0, 0, 0, 0, 0) ON CONFLICT(userid) DO NOTHING;";
            executeNonQuery(sqlStr);
            sqlStr = $"SELECT * FROM Business WHERE business_name = '{name}' AND address = '{address}';";
            executeQuery(sqlStr, getBusinessId);
            sqlStr = $"SELECT tip_date, username, num_of_likes, tip_text FROM Tip INNER JOIN Users ON Users.userid = Tip.userid WHERE business_id = '{business_id}' ORDER BY tip_date desc;";
            executeQuery(sqlStr, addTipsTable);
            sqlStr = $"SELECT DISTINCT friend_id FROM friends WHERE userid = '{main_set.userDataGrid.SelectedCells[0].Value.ToString()}';";
            executeQuery(sqlStr, getFriendID);
        }

        private string buildConnectionString()
        {
            return "Host = localhost; Username = postgres; Database = yelpdb; password = Password123;";
        }

        public void executeQuery(string sqlStr, Action<NpgsqlDataReader> myf)
        {
            using (var connection = new NpgsqlConnection(buildConnectionString()))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = sqlStr;
                    try
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                            myf(reader);
                    }
                    catch (NpgsqlException ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                        //System.Windows.MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void executeNonQuery(string sqlStr)
        {
            using (var connection = new NpgsqlConnection(buildConnectionString()))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = sqlStr;
                    try
                    {
                        int affected = cmd.ExecuteNonQuery();
                    }
                    catch (NpgsqlException ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                        //System.Windows.MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void getBusinessId(NpgsqlDataReader reader)
        {
            business_id = reader.GetString(0);
        }

        private void addTipsTable(NpgsqlDataReader reader)
        {
            tipsGrid.Rows.Add(reader.GetTimeStamp(0).ToString(), reader.GetString(1), reader.GetValue(2), reader.GetString(3));
        }

        private void getFriendID(NpgsqlDataReader reader)
        {
            string sqlStr = $"SELECT username, tip_text, tip_date FROM tip INNER JOIN users ON tip.userid = users.userid INNER JOIN business ON tip.business_id = business.business_id WHERE tip.business_id = '{business_id}' AND tip.userid = '{reader.GetString(0)}' ORDER BY tip_date DESC;";
            executeQuery(sqlStr, addFriendTip);
        }

        private void addFriendTip(NpgsqlDataReader reader)
        {
            dataGridView1.Rows.Add(reader.GetString(0), reader.GetDateTime(2), reader.GetString(1));
        }

        private void addTip_Click(object sender, EventArgs e)
        {
            string tip = tipTextBox.Text;
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if(tip.Length != 0)
            {
                
                string sqlStr = $"INSERT INTO Tip(userid, business_id, tip_text, tip_date, num_of_likes) VALUES('{main_set.userDataGrid.SelectedCells[0].Value.ToString()}', '{business_id}', '{tip}', '{timestamp}', 0);";
                executeNonQuery(sqlStr);
                tipsGrid.Rows.Clear();
                main_set.refresh_user();
                main_set.refresh_business();
                sqlStr = $"SELECT tip_date, username, num_of_likes, tip_text FROM Tip INNER JOIN Users ON Users.userid = Tip.userid WHERE business_id = '{business_id}' ORDER BY tip_date desc;";
                executeQuery(sqlStr, addTipsTable);
            }
            tipTextBox.Clear();
        }

        private void tipsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tipsGrid.SelectedRows[0];
            this.tip_date = row.Cells["date"].Value.ToString();
            this.name = row.Cells["username"].Value.ToString();
            likeButton.Visible = true;
        }

        private void likeTip(NpgsqlDataReader reader)
        {
            string userid = reader.GetString(0).ToString();
            string businessid = reader.GetString(1).ToString();
            string tip_text = reader.GetString(2).ToString();
            string sqlStr = $"UPDATE Tip SET num_of_likes = num_of_likes + 1 WHERE userid = '{userid}' and business_id = '{this.business_id}' and tip_text = '{tip_text}';";
            executeNonQuery(sqlStr);
            tipsGrid.Rows.Clear();
            main_set.refresh_user();
            sqlStr = $"SELECT tip_date, username, num_of_likes, tip_text FROM Tip INNER JOIN Users ON Users.userid = Tip.userid WHERE business_id = '{this.business_id}' ORDER BY tip_date desc;";
            executeQuery(sqlStr, addTipsTable);
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            string sqlStr = $"SELECT Tip.userid, business_id, tip_text FROM Tip INNER JOIN Users on Users.userid = Tip.userid WHERE business_id = '{this.business_id}' AND tip_date = '{this.tip_date}' AND username = '{this.name}';";
            executeQuery(sqlStr, likeTip);
        }
    }
}
