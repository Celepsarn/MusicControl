using MusicControl.dto;
using MusicControl.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicControl.Business
{
    class FunctionController
    {
        public FunctionController(){}

        public List<InterpretDTO> getAllInterprets()
        {
            List<InterpretDTO> interprets = new List<InterpretDTO>();
            InterpretDAO iDAO = new InterpretDAO();
            interprets = iDAO.getAllFromDb();
            return interprets;
        }

        public List<GenreDTO> getAllGenres()
        {
            List<GenreDTO> genres = new List<GenreDTO>();
            GenreDAO gDAO = new GenreDAO();
            genres = gDAO.getAllFromDb();
            return genres;
        }

        public void deleteInterpret(string name)
        {
            InterpretDAO iDAO = new InterpretDAO();
            iDAO.deleteInterpret(name);
        }

        public bool objectAlreadyExists(string name, string objectType)
        {
            if (objectType == "Interpret")
            {
                InterpretDAO iDAO = new InterpretDAO();

                if (iDAO.getInterpretByName(name) != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (objectType == "Genre")
            {
                GenreDAO gDAO = new GenreDAO();

                if (gDAO.getGenreByName(name).Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Fehler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<String> getAlbumsByInterpret(string interpret)
        {
            List<String> albums = new List<String>();
            AlbumDAO aDAO = new AlbumDAO();
            InterpretDAO iDAO = new InterpretDAO();
            albums = aDAO.getAllByInterpret(iDAO.getIdFromDb(interpret));
            return albums;
        }

        public InterpretDTO getInterpretByName(string name)
        {
            InterpretDAO iDAO = new InterpretDAO();
            return iDAO.getInterpretByName(name);
        }
    }
}
