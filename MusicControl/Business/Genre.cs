using MusicControl.dto;
using MusicControl.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.Business
{
    class Genre
    {
        string name;

        public Genre(string name)
        {
            this.name = name;
        }

        public void create()
        {
            GenreDTO gDTO = new GenreDTO(name);
            GenreDAO gDAO = new GenreDAO();
            gDAO.insertGenre(gDTO);
        }
    }
}
