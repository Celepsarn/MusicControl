using MusicControl.dto;
using MusicControl.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
