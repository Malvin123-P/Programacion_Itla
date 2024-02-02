using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Class
{
    sealed class Maestro : Docente
    {
        public Maestro(string Name, string LastName, int Age) : base(Name, LastName, Age)
        {

        }
    }
}
