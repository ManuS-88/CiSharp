using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class Audi:Auto
    {
        public string Modelo { get; set; }

        private string marca = "Audi";

        public Audi(int hP, string color, string modelo):base(hP, color)
        {
            this.Modelo = modelo;
        }

        public new void MostrarDetalles()
        {
            Console.WriteLine("Los caballos son: {0}, el color es {1}, de marca: {2} y modelo: {3}", HP, Color, marca, Modelo);

        }

        public override void Reparar()
        {
            Console.WriteLine("Auto Audi {0} esta reparado", Modelo);
        }
    }
}
