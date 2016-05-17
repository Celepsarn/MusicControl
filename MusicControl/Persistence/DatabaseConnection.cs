using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MusicControl.Persistence
{
    class DatabaseConnection
    {
        MySqlConnection conn;

        static void connect()
        {
            string connectionString = "Server=localhost;Port=3306;Databse=db_musiccontrol;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connectionString);
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
