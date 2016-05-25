using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MusicControl.dto
{
    class InterpretDTO
    {
        string name;
        string foundationYear;
        string land;

        public InterpretDTO(string name, string foundationYear, string land)
        {
            this.name = name;
            this.foundationYear = foundationYear;
            this.land = land;
        }

        public string getName()
        {
            return name;
        }

        public string getFoundationYear()
        {
            return foundationYear;
        }

        public string getLand()
        {
            return land;
        }
    }


}
