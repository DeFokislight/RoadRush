using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesApp
{
    internal class database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=calories");
        
        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open(); //подключаемся к БД если не подключены
                MessageBox.Show("Введите фамилию");
            }
        }
        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close(); //отключаемся от БД если подключены
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
