using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Class;

namespace ConsoleApp
{
    sealed class Administrativo : Empleados
    {
        public Administrativo(string Name, string LastName, int Age) : base(Name, LastName, Age)
        {

        }
    }
}
