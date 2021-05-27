using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            // string passUser = passField.Text;

            connection1 db = new connection1();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM users WHERE Login = @uL ", db.getConnection());
            MySqlCommand command = mySqlCommand;
            command.Parameters.Add("@uL", MySqlDbType.VarChar);
            command.Parameters["@uL"].Value = loginField.Text;
          //  command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            //  MessageBox.Show("Yes");
            {
                new Form2().Show();
               // this.Close();
            }
            else
                MessageBox.Show("No");
        }

    }
}
