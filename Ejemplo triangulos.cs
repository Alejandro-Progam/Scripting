using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la variable C");
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la variable B");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la variable W");
            double W = double.Parse(Console.ReadLine());

            double CR = C * (Math.PI / 180);
            double BR = B * (Math.PI / 180);

            double A = 180 - (90 + C);
            double AR = A * (Math.PI / 180);
           
            double Z = Math.Cos(AR+ BR)*W;
            double Y = Math.Tan(AR)*Z;
            
            Console.WriteLine("y es igual a:" + " " + Y);
        }
    }
}
