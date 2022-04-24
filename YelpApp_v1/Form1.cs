﻿using System;
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
    public partial class Form1 : Form
    {
        public class Business
        {
            public string bid { get; set; }
            public string name { get; set; }
            public string state { get; set; }
            public string city { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            addState();
            userSearchBox.Click += TextBoxOnClick;
        }

        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
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

        public void refresh_user()
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            string sql = $"SELECT username, avg_stars, fans_count, signed_up, funny, cool, useful, tip_count, like_count, latitude, longitude from users WHERE userid = '{userDataGrid.SelectedCells[0].Value.ToString()}';";
            executeQuery(sql, addUserInfo);
            tabPage1.Enabled = true;
            editButton.Enabled = true;
            updateButton.Enabled = false;
            userLat.ReadOnly = true;
            userLong.ReadOnly = true;
            refreshButton.Enabled = true;
        }

        private void addState(NpgsqlDataReader reader)
        {
            State.Items.Add(reader.GetString(0));
        }

        private void addState()
        {
            string sqlStr = "SELECT distinct state FROM business ORDER BY state;";
            executeQuery(sqlStr, addState);

        }

        private void addCity(NpgsqlDataReader reader)
        {
            City.Items.Add(reader.GetString(0));
        }

        private void addZip(NpgsqlDataReader reader)
        {
            Zip.Items.Add(reader.GetValue(0));
        }

        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTips.Visible = false;
            infoName.Visible = false;
            infoAddress.Visible = false;
            label5.Visible = true;
            Zip.Items.Clear();
            Categories.Items.Clear();
            businessGrid.Rows.Clear();
            if (State.SelectedIndex > -1)
            {
                string sqlStr = $"SELECT distinct zip FROM business WHERE city = '{City.SelectedItem.ToString()}' ORDER BY zip;";
                executeQuery(sqlStr, addZip);
            }
        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTips.Visible = false;
            infoName.Visible = false;
            infoAddress.Visible = false;
            label5.Visible = true;
            City.Items.Clear();
            Zip.Items.Clear();
            businessGrid.Rows.Clear();
            Categories.Items.Clear();
            if (State.SelectedIndex > -1)
            {
                string sqlStr = $"SELECT distinct city FROM business WHERE state = '{State.SelectedItem.ToString()}' ORDER BY city;";
                executeQuery(sqlStr, addCity);
            }
        }

        private void addCheckRow(NpgsqlDataReader reader)
        {
            Categories.Items.Add(reader.GetString(0), CheckState.Unchecked);
        }

        private void addBusinessRow(NpgsqlDataReader reader)
        {
            double distance = 0;
            businessGrid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), distance, reader.GetDouble(4), reader.GetInt32(7), reader.GetInt32(8));
        }

        private void Zip_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTips.Visible = false;
            infoName.Visible = false;
            infoAddress.Visible = false;
            label5.Visible = true;
            businessGrid.Rows.Clear();
            Categories.Items.Clear();
            if (Zip.SelectedIndex > -1)
            {
                string sqlStr = $"SELECT DISTINCT cat_name FROM businessCategory INNER JOIN Business ON businesscategory.business_id = Business.Business_id WHERE Zip = '{Zip.SelectedItem.ToString()}' ORDER BY cat_name;";
                executeQuery(sqlStr, addCheckRow);
                sqlStr = $"SELECT business_name, address, city, state, rating, latitude, longitude, tip_count, checkins_count FROM Business WHERE Zip = '{Zip.SelectedItem.ToString()}' ORDER BY business_name;";
                executeQuery(sqlStr, addBusinessRow);
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (Categories.CheckedItems.Count == 0)
            {
                businessGrid.Rows.Clear();
                string sqlStr1 = $"SELECT  business_name, address, city, state, rating, latitude, longitude, tip_count, checkins_count FROM Business WHERE Zip = '{Zip.SelectedItem.ToString()}' ORDER BY business_name;";
                executeQuery(sqlStr1, addBusinessRow);
                return;
            }
            businessGrid.Rows.Clear();
            showTips.Visible = false;
            infoName.Visible = false;
            infoAddress.Visible = false;
            label5.Visible = true;
            string sqlStr = $"SELECT DISTINCT  business_name, address, city, state, rating, latitude, longitude, tip_count, checkins_count FROM Business WHERE zip = '{Zip.SelectedItem.ToString()}' AND business_id IN (SELECT business_id FROM businesscategory";
            foreach (String item in Categories.CheckedItems)
            {
                    sqlStr += $" WHERE cat_name = '{item}' INTERSECT SELECT business_id FROM businesscategory";
            }
            sqlStr += ");";
            executeQuery(sqlStr, addBusinessRow);
        }

        private void addInfo(NpgsqlDataReader reader)
        {
            infoName.Text = reader.GetString(1);
            infoAddress.Text = $"{reader.GetString(2)}, {reader.GetString(4)}, {reader.GetString(3)}";
            label5.Visible = false;
            showTips.Visible = true;
            infoName.Visible = true;
            infoAddress.Visible = true;
        }

        private void showTips_Click(object sender, EventArgs e)
        {
            Form2 tips = new Form2(this);
            tips.Show();
        }

        private void businessGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = businessGrid.SelectedRows[0];
            string name = row.Cells["name_col"].Value.ToString();
            string address = row.Cells["address_col"].Value.ToString();
            string sqlStr = $"SELECT * FROM Business WHERE business_name = '{name}' AND address = '{address}';";
            executeQuery(sqlStr, addInfo);
        }

        private void addUserRow(NpgsqlDataReader reader)
        {
            userDataGrid.Rows.Add(reader.GetString(0));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void userDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void userSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                userDataGrid.Rows.Clear();

                if (userSearchBox.Text.Length != 0)
                {

                    string text = "%";
                    text = userSearchBox.Text;
                    text += "%";
                    if (!userSearchBox.Text.Contains(' '))
                    {
                        string sqlStr = $"SELECT userid FROM Users WHERE username LIKE '{text}' ORDER BY userid;";
                        executeQuery(sqlStr, addUserRow);
                    }
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (!tabPage1.Enabled && tabControl1.SelectedTab==tabPage1) 
            { 
                MessageBox.Show("Please select a user.", "Error: User Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabPage2; 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = true;
            userLat.ReadOnly = false;
            userLong.ReadOnly = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            double latitude;
            double longitude;
            bool success = Double.TryParse(userLat.Text, out latitude);
            bool success2 = Double.TryParse(userLong.Text, out longitude);
            if(!success || !success2)
            {
                MessageBox.Show("Issue parsing a coordinate. Please try again.", "Error: Double Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = $"UPDATE users SET latitude = '{latitude}', longitude = '{longitude}' WHERE userid = '{userDataGrid.SelectedCells[0].Value.ToString()}'";
            executeNonQuery(sql);
            userLat.ReadOnly = true;
            userLong.ReadOnly = true;
        }

        private void addUserInfo(NpgsqlDataReader reader)
        {
            userinfoName.Text = reader.GetString(0);
            userinfoStars.Text = reader.GetDouble(1).ToString();
            userinfoFans.Text = reader.GetInt32(2).ToString();
            userinfoDate.Text = reader.GetDate(3).ToString();
            userinfoFunny.Text = reader.GetInt32(4).ToString();
            userinfoCool.Text = reader.GetInt32(5).ToString();
            userinfoUseful.Text = reader.GetInt32(6).ToString();
            userinfoTipCount.Text = reader.GetInt32(7).ToString();
            userinfoTipLikes.Text = reader.GetInt32(8).ToString();
            userLat.Text = reader.GetDouble(9).ToString();
            userLong.Text = reader.GetDouble(10).ToString();
            string sqlStr = $"SELECT DISTINCT friend_id FROM friends WHERE userid = '{userDataGrid.SelectedCells[0].Value.ToString()}';";
            executeQuery(sqlStr, getFriendID);
        }

        private void getFriendID(NpgsqlDataReader reader)
        {
            string sqlStr = $"SELECT username, avg_stars, signed_up FROM users WHERE userid = '{reader.GetString(0)}';";
            executeQuery(sqlStr, addFriendInfo);
            sqlStr = $"SELECT username, business_name, city, tip_text, tip_date FROM tip INNER JOIN users ON tip.userid = users.userid INNER JOIN business ON tip.business_id = business.business_id WHERE tip.userid = '{reader.GetString(0)}' ORDER BY tip_date DESC LIMIT 1;";
            executeQuery(sqlStr, addFriendTip);
        }

        private void addFriendInfo(NpgsqlDataReader reader)
        {
            dataGridView2.Rows.Add(reader.GetString(0), reader.GetDouble(1).ToString(), reader.GetDateTime(2).ToString());
        }

        private void addFriendTip(NpgsqlDataReader reader)
        {
            dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4));
        }

        private void userDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userDataGrid.SelectedRows.Count == 0)
            {
                dataGridView2.Rows.Clear();
                dataGridView1.Rows.Clear();
                tabPage1.Enabled = false;
                editButton.Enabled = false;
                updateButton.Enabled = false;
                refreshButton.Enabled = false;
                userinfoName.Text = null;
                userinfoStars.Text = null;
                userinfoFans.Text = null;
                userinfoDate.Text = null;
                userinfoFunny.Text = null;
                userinfoCool.Text = null;
                userinfoUseful.Text = null;
                userinfoTipCount.Text = null;
                userinfoTipLikes.Text = null;
                userLat.Text = null;
                userLong.Text = null;
                return;
            }
            else if (userDataGrid.SelectedCells[0].Value == null)
            {
                dataGridView2.Rows.Clear();
                dataGridView1.Rows.Clear();
                tabPage1.Enabled = false;
                editButton.Enabled = false;
                updateButton.Enabled = false;
                refreshButton.Enabled = false;
                userinfoName.Text = null;
                userinfoStars.Text = null;
                userinfoFans.Text = null;
                userinfoDate.Text = null;
                userinfoFunny.Text = null;
                userinfoCool.Text = null;
                userinfoUseful.Text = null;
                userinfoTipCount.Text = null;
                userinfoTipLikes.Text = null;
                userLat.Text = null;
                userLong.Text = null;
                return;
            }
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            string sql = $"SELECT username, avg_stars, fans_count, signed_up, funny, cool, useful, tip_count, like_count, latitude, longitude from users WHERE userid = '{userDataGrid.SelectedCells[0].Value.ToString()}';";
            executeQuery(sql, addUserInfo);
            tabPage1.Enabled = true;
            editButton.Enabled = true;
            refreshButton.Enabled = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            string sql = $"SELECT username, avg_stars, fans_count, signed_up, funny, cool, useful, tip_count, like_count, latitude, longitude from users WHERE userid = '{userDataGrid.SelectedCells[0].Value.ToString()}';";
            executeQuery(sql, addUserInfo);
            tabPage1.Enabled = true;
            editButton.Enabled = true;
            updateButton.Enabled = false;
            userLat.ReadOnly = true;
            userLong.ReadOnly = true;
            refreshButton.Enabled = true;
        }

        private void userSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userSearchBox_Click(object sender, EventArgs e)
        {
            if (userSearchBox.Text == "Enter User Name")
            {
                userSearchBox.Clear();
            }
        }

        private void userSearchBox_Leave(object sender, EventArgs e)
        {
            if(userDataGrid.SelectedRows.Count > 0)
            {
                return;
            }
            if (userSearchBox.Text.Length == 0)
            {
                userSearchBox.Text = "Enter User Name";
                return;
            }
            userDataGrid.Rows.Clear();

            if (userSearchBox.Text.Length != 0)
            {

                string text = "%";
                text = userSearchBox.Text;
                text += "%";
                if (!userSearchBox.Text.Contains(' '))
                {
                    string sqlStr = $"SELECT userid FROM Users WHERE username LIKE '{text}' ORDER BY userid;";
                    executeQuery(sqlStr, addUserRow);
                }
            }
        }
    }
}
