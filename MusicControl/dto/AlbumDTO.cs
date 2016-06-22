using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.dto
{
    class AlbumDTO
    {
        string name;
        string releaseYear;
        int genre;
        int interpret;
        string coverpath;

        public AlbumDTO(string name, string releaseYear, int genre, int interpret, string coverpath)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.genre = genre;
            this.interpret = interpret;
            this.coverpath = coverpath;
        }

        public string getName()
        {
            return name;
        }

        public string getReleaseYear()
        {
            return releaseYear;
        }

        public int getGenre()
        {
            return genre;
        }

        public int getInterpret()
        {
            return interpret;
        }

        public string getCoverpath()
        {
            return coverpath;
        }
    }
}
