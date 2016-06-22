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

        public List<SongDTO> getAllSongsByAlbum(string album)
        {
            SongDAO sDAO = new SongDAO();
            AlbumDAO aDAO = new AlbumDAO();
            return sDAO.getAllFromDbByAlbumId(aDAO.getIdFromDb(album));
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

                if (iDAO.getInterpretByName(name) == null)
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

        public AlbumDTO getAlbumByName(string name)
        {
            AlbumDAO aDAO = new AlbumDAO();
            return aDAO.getAlbumByName(name);
        }

        public String getInterpretNameById(int id)
        {
            InterpretDAO iDAO = new InterpretDAO();
            return iDAO.getInterpretNameById(id);
        }

        public AlbumDTO getAlbumById(int id)
        {
            AlbumDAO aDAO = new AlbumDAO();
            return aDAO.getAlbumById(id);
        }

        public String getGenreById(int id)
        {
            GenreDAO gDAO = new GenreDAO();
            return gDAO.getGenreById(id);
        }

        public int getInterpretIdByName(string name)
        {
            InterpretDAO iDAO = new InterpretDAO();
            return iDAO.getIdFromDb(name);
        }

        public int getGenreIdByName(string name)
        {
            GenreDAO gDAO = new GenreDAO();
            return gDAO.getIdFromDb(name);
        }

        public string addCover()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png";
            ofd.Filter = "JPG|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                return null;
            }
            
        }

        public void updateAlbum(AlbumDTO obj)
        {
            AlbumDAO aDAO = new AlbumDAO();
            aDAO.updateAlbum(obj, aDAO.getIdFromDb(obj.getName()));
        }

        public void updateInterpret(InterpretDTO obj)
        {
            InterpretDAO iDAO = new InterpretDAO();
            iDAO.updateInterpret(obj, iDAO.getIdFromDb(obj.getName()));
        }
    }
}
