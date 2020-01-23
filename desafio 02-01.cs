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
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z= ");
            double z = double.Parse(Console.ReadLine());

            double ar = Math.Atan(y / z);
            double a = ar * (180 / Math.PI);
            double c = 180 - (90 + a);
            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
            Console.WriteLine("a=" + a);
            Console.WriteLine("c=" + c);
            Console.WriteLine("t=" + t);



        }
    }
}
