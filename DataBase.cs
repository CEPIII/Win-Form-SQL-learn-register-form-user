using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSQLearn
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=dbase");

        public void openConnection()
        {
            //Если база данных закрыта, то открываем соединение
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            //Если база данных открыта, то закрываем соединение
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
