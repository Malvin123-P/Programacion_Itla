using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Class
{
    internal class Docente : Empleados
    {
        public Docente(string Name, string LastName, int Age) : base(Name, LastName, Age)
        {

        }
    }
}
