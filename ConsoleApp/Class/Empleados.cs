using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Class
{
    internal class Empleados : MiembrosdelaComunidad
    {
        private double Salary { get; set; }
        private string hiringDate { get; set; }

        public Empleados(string Name, string LastName, int Age) : base(Name, LastName, Age)
        {

        }

        public override void SeeName()
        {
            throw new NotImplementedException();
        }
    }
}
