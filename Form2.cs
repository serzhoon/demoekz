using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3305;username=root;password=JannoWrage0909;database=scheme1");
        public SD.DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
         
            string script = "Select * from leads_and_calls";
            MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connection);
            SD.DataTable table = new SD.DataTable();
            ms_data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

    }
}
