using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class Pasante : Empleado
    {
        public int HorasDeTrabajo { get; set; }
        public int HorasDeEscuela { get; set; }
        public Pasante() { }

        public Pasante(string nombre, string apellido, int salario, int horasDeTrabajo, int horasDeEscuela)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
            this.HorasDeTrabajo = horasDeTrabajo;
            this.HorasDeEscuela = horasDeEscuela;
        }

        public void Aprender()
        {
            Console.WriteLine("Estoy aprendiendo durante {0} horas",this.HorasDeEscuela);
        }

        public void TrabajarPasante()
        {
            Console.WriteLine("Trabaje {0} horas.", this.HorasDeTrabajo);
        }
    }
}
