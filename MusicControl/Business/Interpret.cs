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

            InterpretDTO i = new InterpretDTO(name, foundationYear, land);
            
        }

  //      public ArrayList<InterpretDTO> getAll()
  //      {
  //          ArrayList interprets = new ArrayList();
  //          return interprets;
  //      }
    }
}