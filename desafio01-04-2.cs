using System;

namespace Desafio04_01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese variable b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese variable d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese variable y");
            double y = double.Parse(Console.ReadLine());
            // primero hay que hallar el angulo a 
            double a = 90 - d - b;
            //Luego hallo el cateto opuestao del angulo a+b
            double z = y / (Math.Tan(a * Math.PI / 180));
            Console.WriteLine("z=" + " " + z);

        }
    }
}
