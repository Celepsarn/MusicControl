using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.dto
{
    public class SongDTO
    {
        string name;
        string trackNo;
        string duration;
        string songtext;
        int album;

        public SongDTO(string name, string trackNo, string duration, string songtext, int album)
        {
            this.name = name;
            this.trackNo = trackNo;
            this.duration = duration;
            this.songtext = songtext;
            this.album = album;
        }

        public string getName()
        {
            return name;
        }

        public string getTrackNo()
        {
            return trackNo;
        }

        public string getDuration()
        {
            return duration;
        }

        public string getSongtext()
        {
            return songtext;
        }

        public int getAlbum()
        {
            return album;
        }
    }
}
