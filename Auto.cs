using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    public class Auto
    {
        public  int HP { get; set; }
        public string? Color { get; set; }

        public Auto(int hP, string color)
        {
            this.HP = hP;
            this.Color = color;

        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Los caballos son: {0} y el color es {1}", HP, Color); 

        }

        public virtual void Reparar()
        {
            Console.WriteLine("Auto reparado");
        }
    }


    




}
