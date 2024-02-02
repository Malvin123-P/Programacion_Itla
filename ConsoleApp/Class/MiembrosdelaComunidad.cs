using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Class
{
    abstract class MiembrosdelaComunidad
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }

        protected MiembrosdelaComunidad(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        public abstract void SeeName();
    }
}
