using System;

namespace Desafío01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese variable w");
            double w = double.Parse(Console.ReadLine()) ;
            Console.WriteLine("Ingrese variable t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese variable c");
            double c = double.Parse(Console.ReadLine());
            // primero hay que hallar el lado y
            double y = Math.Cos(c * Math.PI / 180)*t;
            //luego hallo el lado z 
            double z = Math.Sin(c * Math.PI / 180) * t;
            // luego utilizo teorema de pitagoras 
            double n = Math.Pow(w, 2) - Math.Pow(z, 2);
            double x = Math.Sqrt(n) - y;
            Console.Write("x=" + x);

        
        }
    }
}