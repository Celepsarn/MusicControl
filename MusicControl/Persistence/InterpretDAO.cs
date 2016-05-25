using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MusicControl.dto;

namespace MusicControl.Persistence
{
    class InterpretDAO
    {
        public void insertInterpret(InterpretDTO obj)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "INSERT INTO tbl_interpret VALUES (" + obj.getName() + ", " + obj.getFoundationYear() + ", " + obj.getLand() + ");";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }
    }
}
