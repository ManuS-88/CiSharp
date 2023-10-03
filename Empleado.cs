using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }

        public Empleado() { }

        public Empleado(string nombre, string apellido, int salario)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
        }

        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando.");
        }

        public void Descansar()
        {
            Console.WriteLine("Estoy descansando.");
        }
    }

}
