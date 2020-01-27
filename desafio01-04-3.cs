using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese variable w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese variable d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese variable x ");
            double x = double.Parse(Console.ReadLine());
            // primero hay que hallar el angulo a 
            double y = w * Math.Cos(d * Math.PI / 180) - x;
            Console.WriteLine("Y=" + " " + y);
        }
    }
}
