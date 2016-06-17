using MusicControl.dto;
using MusicControl.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.Business
{
    class Album
    {
        string name;
        string releaseYear;
        int genre;
        int interpret;

        public Album(string name, string releaseYear, string genre, string interpret)
        {
            InterpretDAO iDAO = new InterpretDAO();
            GenreDAO gDAO = new GenreDAO();
            this.name = name;
            this.releaseYear = releaseYear;
            this.genre = gDAO.getIdFromDb(genre);
            this.interpret = iDAO.getIdFromDb(interpret);

            AlbumDTO aDTO = new AlbumDTO(name, releaseYear, this.genre, this.interpret);
        }

        public void create()
        {
            AlbumDTO aDTO = new AlbumDTO(name, releaseYear, genre, interpret);
            AlbumDAO aDAO = new AlbumDAO();
            aDAO.insertAlbum(aDTO);
        }
    }
}
