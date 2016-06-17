using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicControl.dto
{
    class GenreDTO
    {
        string name;

        public GenreDTO(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
