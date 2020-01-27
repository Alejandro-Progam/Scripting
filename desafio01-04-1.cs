using System;

namespace Desafío01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese variable b");
            double b = double.Parse(Console.ReadLine())*(Math.PI/180) ;
            Console.WriteLine("Ingrese variable z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese variable y");
            double y = double.Parse(Console.ReadLine());
            // primero hay que hallar el angulo a 
            double a = Math.Atan(y / z);
            //Luego hallo el cateto opuestao del angulo a+b
            double x = (Math.Tan(a + b) * z) - y;
            Console.WriteLine("x=" + " " + x);
        }
    }
}
