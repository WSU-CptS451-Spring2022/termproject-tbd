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
        }

        private string buildConnectionString()
        {
            return "Host = localhost; Username = postgres; Database = yelpdb; password = password;";
        }

        private void executeQuery(string sqlStr, Action<NpgsqlDataReader> myf)
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
            Zip.Items.Clear();
            if (State.SelectedIndex > -1)
            {
                string sqlStr = $"SELECT distinct zip FROM business WHERE city = '{City.SelectedItem.ToString()}' ORDER BY zip;";
                executeQuery(sqlStr, addZip);
            }
        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            City.Items.Clear();
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
            businessGrid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetDouble(2));
        }

        private void Zip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Zip.SelectedIndex > -1)
            {
                businessGrid.Rows.Clear();
                Categories.Items.Clear();
                string sqlStr = $"SELECT DISTINCT cat_name FROM businessCategory INNER JOIN Business ON businesscategory.business_id = Business.Business_id WHERE Zip = '{Zip.SelectedItem.ToString()}' ORDER BY cat_name;";
                executeQuery(sqlStr, addCheckRow);
                sqlStr = $"SELECT business_name, address, rating FROM Business WHERE Zip = '{Zip.SelectedItem.ToString()}' ORDER BY business_name;";
                executeQuery(sqlStr, addBusinessRow);
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if(Categories.CheckedItems.Count == 0)
            {
                businessGrid.Rows.Clear();
                string sqlStr1 = $"SELECT business_name, address, rating FROM Business WHERE Zip = '{Zip.SelectedItem.ToString()}' ORDER BY business_name;";
                executeQuery(sqlStr1, addBusinessRow);
                return;
            }
            businessGrid.Rows.Clear();
            string sqlStr = $"SELECT DISTINCT business_name, address, rating FROM Business WHERE zip = '{Zip.SelectedItem.ToString()}' AND business_id IN (SELECT business_id FROM businesscategory";
            foreach (String item in Categories.CheckedItems)
            {
                    sqlStr += $" WHERE cat_name = '{item}' INTERSECT SELECT business_id FROM businesscategory";
            }
            sqlStr += ");";
            executeQuery(sqlStr, addBusinessRow);
        }
    }
}
