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
        private DatabaseConnection(){}

        //Singleton for the databaseconnection
        //Returns the instance
        public static DatabaseConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
                
            }
            return instance;
        }

        //Connects to the database
        private void connect()
        {
            string connectionString = "Server=localhost;Port=3306;Database=db_musiccontrol;Uid=root;password=;";
            this.conn = new MySqlConnection(connectionString);
        }

        //Gets the connection. If conn isn't defined yet connect() is called
        //Returns conn
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
