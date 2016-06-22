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
        string coverpath;

        public Album(string name, string releaseYear, string genre, string interpret, string coverpath)
        {
            InterpretDAO iDAO = new InterpretDAO();
            GenreDAO gDAO = new GenreDAO();
            this.name = name;
            this.releaseYear = releaseYear;
            this.genre = gDAO.getIdFromDb(genre);
            this.interpret = iDAO.getIdFromDb(interpret);
            this.coverpath = coverpath;

            AlbumDTO aDTO = new AlbumDTO(name, releaseYear, this.genre, this.interpret, coverpath);
        }

        public void create()
        {
            AlbumDTO aDTO = new AlbumDTO(name, releaseYear, genre, interpret, coverpath);
            AlbumDAO aDAO = new AlbumDAO();
            aDAO.insertAlbum(aDTO);
        }

        public void delete(string name)
        {
            FunctionController fc = new FunctionController();
            AlbumDAO aDAO = new AlbumDAO();
            List<SongDTO> songs = new List<SongDTO>();
            songs = fc.getAllSongsByAlbum(name);
            foreach (SongDTO song in songs)
            {
                Song s = new Song(song.getName(), "", "", "", "");
                s.delete(song.getName());

            }
            aDAO.deleteAlbum(name);

        }
    }
}
