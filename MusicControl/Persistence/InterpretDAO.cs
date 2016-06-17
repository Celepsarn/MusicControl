﻿using System;
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
        public InterpretDAO(){}

        public void insertInterpret(InterpretDTO obj)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "INSERT INTO tbl_interpret(name, foundationyear, land) VALUES ('" + obj.getName() + "', '" + obj.getFoundationYear() + "', '" + obj.getLand() + "');";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }

        public List<InterpretDTO> getAllFromDb()
        {
            List<InterpretDTO> interprets = new List<InterpretDTO>();

            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_Interpret ORDER BY name ASC;";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InterpretDTO i = new InterpretDTO(reader["name"].ToString(), reader["foundationYear"].ToString(), reader["land"].ToString());
                interprets.Add(i);
            }
            mysqlcon.Close();
            return interprets;
        }

        public InterpretDTO getInterpretByName(string name)
        {
            List<InterpretDTO> interprets = new List<InterpretDTO>();
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_Interpret WHERE name = '" + name + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InterpretDTO i = new InterpretDTO(reader["name"].ToString(), reader["foundationYear"].ToString(), reader["land"].ToString());
                interprets.Add(i);
            }
            mysqlcon.Close();
            return interprets[0];
        }

        public void deleteInterpret(string name)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "DELETE FROM tbl_Interpret WHERE name = '" + name + "';";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();

        }

        public int getIdFromDb(string name)
        {
            int id;
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT id_interpret FROM tbl_Interpret WHERE name = '" + name + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            id = -1;
            while (reader.Read())
            {
                Int32.TryParse(reader["id_interpret"].ToString(), out id);
            }
            mysqlcon.Close();
            return id;
        }
    }
}
