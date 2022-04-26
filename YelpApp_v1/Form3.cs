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
    public partial class Form3 : Form
    {
        public string business_id { get; set;  }
        Form1 main_set;
        public Form3(Form1 main)
        {
            InitializeComponent();
            refreshChart();
            this.business_id = main.bid;
            this.main_set = main;
            string sqlStr = $"SELECT EXTRACT(MONTH FROM check_date), COUNT(business_id) FROM Checkins WHERE Checkins.business_id = '{this.business_id}' GROUP BY extract ORDER BY extract;";
            executeQuery(sqlStr, updateChart);
            
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

        private void updateChart(NpgsqlDataReader reader)
        {
            checkinsChart.Series["CheckIns"].Points[reader.GetInt32(0) -1].YValues[0] += reader.GetInt32(1);
        }

        private void refreshChart()
        {
            checkinsChart.Series["CheckIns"].Points.Clear();
            checkinsChart.Series["CheckIns"].Points.AddXY("January", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("February", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("March", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("April", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("May", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("June", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("July", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("August", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("September", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("October", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("November", 0);
            checkinsChart.Series["CheckIns"].Points.AddXY("December", 0);
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string sqlStr = $"INSERT INTO CheckIns (check_time, check_date, business_id) VALUES ('{time}', '{date}', '{this.business_id}');";
            executeNonQuery(sqlStr);
            MessageBox.Show("You have sucessfully checked in at " + date + " " + time);
            refreshChart();
            this.main_set.refresh_user();
            this.main_set.refresh_business();
            sqlStr = $"SELECT EXTRACT(MONTH FROM check_date), COUNT(business_id) FROM Checkins WHERE Checkins.business_id = '{this.business_id}' GROUP BY extract ORDER BY extract;";
            executeQuery(sqlStr, updateChart);
        }
    }
}
