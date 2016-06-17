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
            command.CommandText = "INSERT INTO tbl_song(name, trackno, duration, songtext, fk_album) VALUES ('" + obj.getName() + "', '" + obj.getTrackNo() + "', '" + obj.getDuration() + "', '" + obj.getSongtext() + "', '" + obj.getAlbum() + "');";
            mysqlcon.Open();
            command.ExecuteNonQuery();
            mysqlcon.Close();
        }
    }
}
