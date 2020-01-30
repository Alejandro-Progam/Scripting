using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su salario (COP)");
            int s = int.Parse(Console.ReadLine());
            if (s < 1755606)
            {
                Console.WriteLine("Su cuota a pagra es: 3400");
            }
            else if (s >= 1755606 && s < 4389015)
            {
                Console.WriteLine("Su cuota a pagar es 12700");
            }
            else
            {
                Console.WriteLine("Su cuota a pagar es 33500");


            }
        }
    }
}
