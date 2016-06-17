using MusicControl.dto;
using MusicControl.Persistence;

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

        public void delete()
        {
            InterpretDAO iDAO = new InterpretDAO();
            iDAO.deleteInterpret(name);
        }

    }
}