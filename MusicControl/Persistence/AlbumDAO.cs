using MusicControl.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.Persistence
{
    class AlbumDAO
    {
        public AlbumDAO() {}

        public void insertAlbum(AlbumDTO obj)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "INSERT INTO tbl_album(name, releaseyear, fk_genre, fk_interpret) VALUES ('" + obj.getName() + "', '" + obj.getReleaseYear() + "', '" + obj.getGenre() + "', '" + obj.getInterpret() + "');";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }

        public int getIdFromDb(string name)
        {
            int id;
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT id_album FROM tbl_Album WHERE name = '" + name + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            id = -1;
            while (reader.Read())
            {
                Int32.TryParse(reader["id_album"].ToString(), out id);
            }
            mysqlcon.Close();
            return id;
        }

        public List<String> getAllByInterpret(int interpret)
        {
            List<String> albums = new List<String>();

            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT tbl_album.name FROM tbl_album INNER JOIN tbl_interpret ON tbl_album.fk_interpret = tbl_interpret.id_interpret WHERE fk_interpret = " + interpret + ";";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String a = reader["name"].ToString();
                albums.Add(a);
            }
            mysqlcon.Close();
            return albums;
        }
    }
}
