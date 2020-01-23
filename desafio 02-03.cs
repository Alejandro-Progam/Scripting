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
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("z= ");
            double z = double.Parse(Console.ReadLine());

            double cr = c * (Math.PI / 180);
            double y = z / Math.Tan(cr);
            double a= 180 - (c + 90);
            double t = z / Math.Sin(cr);
            Console.WriteLine("y=" + y);
            Console.WriteLine("a=" + a);

            Console.WriteLine("t=" + t);



        }
    }
}