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
        public Form2(Form1 main)
        {
            InitializeComponent();
            DataGridViewRow row = main.businessGrid.SelectedRows[0];
            string name = row.Cells["name_col"].Value.ToString();
            string address = row.Cells["address_col"].Value.ToString();
            string sqlStr = $"SELECT * FROM Business WHERE business_name = '{name}' AND address = '{address}';";
        }

        private void addTip_Click(object sender, EventArgs e)
        {
            string tip = tipTextBox.Text;
            tipTextBox.Clear();
        }
    }
}
