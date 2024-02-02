using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Class
{
    sealed class Estudiante : MiembrosdelaComunidad
    {
        public Estudiante(string Name,string LastName, int Age) : base(Name,LastName, Age)
        {

        }

        public override void SeeName()
        {
            throw new NotImplementedException();
        }
    }
}
