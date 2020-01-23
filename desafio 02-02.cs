using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("t= ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());

            double ar = a * (Math.PI / 180);
            double z = Math.Cos(ar) * t;
            double c = 180-(a+90);
            double y = Math.Sin(ar) * t;
            Console.WriteLine("z=" + z);
            Console.WriteLine("c=" + c);
            Console.WriteLine("y=" + y);



        }
    }
}