using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class Jefe:Empleado
    {
        public string AutoDeEmpresa { get; set; }

        public Jefe() { }

        public Jefe(string nombre, string apellido, int salario, string autoDeEmpresa)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
            this.AutoDeEmpresa = autoDeEmpresa;
        }

        public void Dirigir()
        {
            Console.WriteLine("Soy el jefe.");
        }



    }
}
