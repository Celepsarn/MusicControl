using MusicControl.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.Persistence
{
    class SongDAO
    {
        public SongDAO() { }

        public void insertSong(SongDTO obj)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "INSERT INTO tbl_song(name, trackno, duration, songtext, fk_album) VALUES (@colName, @colTrackno, @colDuration, @colSongtext, @colFK_Album)";
            command.Parameters.AddWithValue("colName", obj.getName());
            command.Parameters.AddWithValue("colTrackno", obj.getTrackNo());
            command.Parameters.AddWithValue("colDuration", obj.getDuration());
            command.Parameters.AddWithValue("colSongtext", obj.getSongtext());
            command.Parameters.AddWithValue("colFK_Album", obj.getAlbum());
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }

        public List<SongDTO> getAllFromDbByAlbumId(int id)
        {
            List<SongDTO> songs = new List<SongDTO>();

            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "SELECT * FROM tbl_song WHERE fk_album = " + id + " ORDER BY trackno ASC;";
            mysqlcon.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int album;
                Int32.TryParse(reader["fk_album"].ToString(), out album);
                SongDTO s = new SongDTO(reader["name"].ToString(), reader["trackno"].ToString(), reader["duration"].ToString(), reader["songtext"].ToString(), album);
                songs.Add(s);
            }
            mysqlcon.Close();
            return songs;
        }

        public void deleteSong(string name)
        {
            MySqlConnection mysqlcon = DatabaseConnection.getInstance().getConnection();
            MySqlCommand command = mysqlcon.CreateCommand();
            command.CommandText = "DELETE FROM tbl_Song WHERE name = '" + name + "';";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();

        }
    }
}
