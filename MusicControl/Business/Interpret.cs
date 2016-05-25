using MusicControl.dto;
using MusicControl.Persistence;
using System;
using System.Collections;

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

            InterpretDTO iDTO = new InterpretDTO(name, foundationYear, land);
            InterpretDAO iDAO = new InterpretDAO();
            iDAO.insertInterpret(iDTO);
            
        }

  //      public ArrayList<InterpretDTO> getAll()
  //      {
  //          ArrayList interprets = new ArrayList();
  //          return interprets;
  //      }
    }
}