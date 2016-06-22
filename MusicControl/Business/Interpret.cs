using MusicControl.dto;
using MusicControl.Persistence;
using System.Collections.Generic;

namespace MusicControl.Business
{
    class Interpret
    {
        string name;
        string foundationYear;
        string land;

        public Interpret(string name, string foundationYear, string land)
        {
            this.name = name;
            this.foundationYear = foundationYear;
            this.land = land;
        }

        public void create()
        {
            InterpretDTO iDTO = new InterpretDTO(name, foundationYear, land);
            InterpretDAO iDAO = new InterpretDAO();
            iDAO.insertInterpret(iDTO);
        }

        public void delete(string name)
        {
            FunctionController fc = new FunctionController();
            InterpretDAO iDAO = new InterpretDAO();
            List <string> albums = new List<string>();
            albums = fc.getAlbumsByInterpret(name);
            foreach (string album in albums)
            {
                Album a = new Album(album, "", "", "", "");
                a.delete(album);
                
            }
            iDAO.deleteInterpret(name);
        }

    }
}