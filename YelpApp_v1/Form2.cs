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

        public Form2(Form1 main)
        {
            InitializeComponent();
            DataGridViewRow row = main.businessGrid.SelectedRows[0];
            string name = row.Cells["name_col"].Value.ToString();
            string address = row.Cells["address_col"].Value.ToString();
            string sqlStr = "INSERT INTO Users(userid, username, signed_up, useful, cool, funny, fans_count, avg_stars, tip_count) VALUES('PROFILE', 'TEST', '03-28-2022', 0, 0, 0, 0, 0, 0) ON CONFLICT(userid) DO NOTHING;";
            executeNonQuery(sqlStr);
            sqlStr = $"SELECT * FROM Business WHERE business_name = '{name}' AND address = '{address}';";
            executeQuery(sqlStr, getBusinessId);
            sqlStr = $"SELECT tip_date, username, num_of_likes, tip_text FROM Tip INNER JOIN Users ON Users.userid = Tip.userid WHERE business_id = '{business_id}' ORDER BY tip_date desc;";
            executeQuery(sqlStr, addTipsTable);
        }

        private string buildConnectionString()
        {
            return "Host = localhost; Username = postgres; Database = yelpdb; password = password;";
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

        private void addTip_Click(object sender, EventArgs e)
        {
            string tip = tipTextBox.Text;
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if(tip.Length != 0)
            {
                string sqlStr = $"INSERT INTO Tip(userid, business_id, tip_text, tip_date, num_of_likes) VALUES('PROFILE', '{business_id}', '{tip}', '{timestamp}', 0);";
                executeNonQuery(sqlStr);
                tipsGrid.Rows.Clear();
                sqlStr = $"SELECT tip_date, username, num_of_likes, tip_text FROM Tip INNER JOIN Users ON Users.userid = Tip.userid WHERE business_id = '{business_id}' ORDER BY tip_date desc;";
                executeQuery(sqlStr, addTipsTable);
            }
            tipTextBox.Clear();
        }
    }
}
