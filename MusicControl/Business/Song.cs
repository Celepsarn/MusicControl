using MusicControl.dto;
using MusicControl.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.Business
{
    class Song
    {
        string name;
        string trackNo;
        string duration;
        string songtext;
        int album;

        public Song(string name, string trackNo, string duration, string songtext, string album)
        {
            AlbumDAO aDAO = new AlbumDAO();
            this.name = name;
            this.trackNo = trackNo;
            this.duration = duration;
            this.songtext = songtext;
            this.album = aDAO.getIdFromDb(album);
        }

        public void create()
        {
            SongDTO sDTO = new SongDTO(name, trackNo, duration, songtext, album);
            SongDAO sDAO = new SongDAO();
            sDAO.insertSong(sDTO);
        }
    }
}
