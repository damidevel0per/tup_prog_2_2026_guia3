using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordado.Models
{
    internal class Flor : IMotivoBordado
    {
        public char[][] GetPatron()
        {
            return new char[][]
            {
            new char[]{' ' ,' ', ' ', ' ' },
            new char[]{' ' ,'\\', '|', '/' },
            new char[]{' ' ,' ','*',' ' },
            new char[]{' ' ,' ','|',' ' },
            };
        }

        public override string ToString()
        {
            return "Flor";
        }


    }

}
