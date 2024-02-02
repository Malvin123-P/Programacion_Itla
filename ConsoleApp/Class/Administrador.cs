using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Class;

namespace ConsoleApp
{
    sealed class Administrador : Docente
    {
        public Administrador(string Name, string LastName, int Age) : base(Name, LastName, Age)
        {

        }
    }
}
