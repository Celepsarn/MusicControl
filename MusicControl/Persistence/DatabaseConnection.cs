using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MusicControl.Persistence
{
    public class DatabaseConnection
    {
        MySqlConnection conn;
        private static DatabaseConnection instance = null;
        private DatabaseConnection()
        {
            
        }
        public static DatabaseConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
                
            }
            return instance;
        }
        private void connect()
        {
            string connectionString = "Server=localhost;Port=3306;Database=db_musiccontrol;Uid=root;password=;";
            this.conn = new MySqlConnection(connectionString);
        }

        public MySqlConnection getConnection()
        {
            if (conn == null)
            {
                this.connect();

            }     
            return conn;
        }
    }
}
