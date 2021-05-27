using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    class connection1
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3305;username=root;password=JannoWrage0909;database=scheme1");
        public void openConnection()
        {
            _ = connection.State == System.Data.ConnectionState.Closed;
                connection.Open();
        }
        public void closeConnection()
        {
            _ = connection.State == System.Data.ConnectionState.Closed;
                connection.Open();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
