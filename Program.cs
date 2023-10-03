using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using CiShparp;
using System.Threading.Channels;

namespace CiSharp
{
   
    class Program
    {
        static void Main(string[] args)
        {

            var autos = new List<Auto>
            {
                new Audi(300, "Verde", "A4"),
                new BMW(300, "Verde", "M3"),
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new BMW(200, "Negro", "Z5");
            Auto auto2 = new Audi(300, "Blanco", "A5");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            BMW auto3 = new BMW(500, "Rosa", "Z8");

            auto3.MostrarDetalles();

            Auto auto4 = (Auto)auto3;

            auto4.MostrarDetalles();
        }
    }
}
