using MusicControl.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.Persistence
{
    class GenreDAO
    {
        public GenreDAO() { }

        public void insertGenre(GenreDTO obj)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "INSERT INTO tbl_genre(name) VALUES ('" + obj.getName() + "');";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }


        public List<GenreDTO> getAllFromDb()
        {
            List<GenreDTO> genres = new List<GenreDTO>();

            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_Genre ORDER BY name ASC;";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GenreDTO g = new GenreDTO(reader["name"].ToString());
                genres.Add(g);
            }
            mysqlcon.Close();
            return genres;
        }

        public List<GenreDTO> getGenreByName(string name)
        {
            List<GenreDTO> genres = new List<GenreDTO>();
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_Genre WHERE name = '" + name + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GenreDTO g = new GenreDTO(reader["name"].ToString());
                genres.Add(g);
            }
            mysqlcon.Close();
            return genres;
        }

        public int getIdFromDb(string name)
        {
            int id;
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT id_genre FROM tbl_Genre WHERE name = '" + name + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            id = -1;
            while (reader.Read())
            {
                Int32.TryParse(reader["id_genre"].ToString(), out id);
            }
            mysqlcon.Close();
            return id;
        }

        public String getGenreById(int id)
        {
            string name = "";
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT name FROM tbl_genre WHERE id_genre = '" + id + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader["name"].ToString();
            }
            mysqlcon.Close();
            return name;
        }

    }
}
