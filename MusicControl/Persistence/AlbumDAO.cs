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
            command.CommandText = "INSERT INTO tbl_album(name, releaseyear, fk_genre, fk_interpret, coverpath) VALUES (@colName, @colReleaseyear, @colFK_genre, @colFK_interpret, @colCoverpath);";
            command.Parameters.AddWithValue("colName", obj.getName());
            command.Parameters.AddWithValue("colReleaseyear", obj.getReleaseYear());
            command.Parameters.AddWithValue("colFK_genre", obj.getGenre());
            command.Parameters.AddWithValue("colFK_interpret", obj.getInterpret());
            command.Parameters.AddWithValue("colCoverpath", obj.getCoverpath());
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }

        public AlbumDTO getAlbumByName(string name)
        {
            List<AlbumDTO> albums= new List<AlbumDTO>();
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_Album WHERE name = '" + name + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int genre;
                int interpret;
                Int32.TryParse(reader["fk_genre"].ToString(), out genre);
                Int32.TryParse(reader["fk_interpret"].ToString(), out interpret);
                AlbumDTO aDTO = new AlbumDTO(reader["name"].ToString(), reader["releaseyear"].ToString(), genre, interpret, reader["coverpath"].ToString());
                albums.Add(aDTO);
            }
            mysqlcon.Close();
            return albums[0];
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

        public AlbumDTO getAlbumById(int id)
        {
            List<AlbumDTO> albums = new List<AlbumDTO>();
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_Album WHERE id_album = '" + id + "';";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int genre;
                int interpret;
                Int32.TryParse(reader["fk_genre"].ToString(), out genre);
                Int32.TryParse(reader["fk_interpret"].ToString(), out interpret);
                AlbumDTO aDTO = new AlbumDTO(reader["name"].ToString(), reader["releaseyear"].ToString(), genre, interpret, reader["coverpath"].ToString());
                albums.Add(aDTO);
            }
            mysqlcon.Close();
            return albums[0];
        }

        public void updateAlbum(AlbumDTO obj, int id)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "UPDATE tbl_album SET name = @colName, releaseyear = @colReleaseyear, fk_genre = @colGenre, fk_interpret = @colInterpret, coverpath = @colCoverpath WHERE id_album = " + id + ";";
            command.Parameters.AddWithValue("colName", obj.getName());
            command.Parameters.AddWithValue("colReleaseyear", obj.getReleaseYear());
            command.Parameters.AddWithValue("colGenre", obj.getGenre());
            command.Parameters.AddWithValue("colInterpret", obj.getInterpret());
            command.Parameters.AddWithValue("colCoverpath", obj.getCoverpath());

            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }

        public void deleteAlbum(string name)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "DELETE FROM tbl_Album WHERE name = '" + name + "';";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();

        }
    }
}
