using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su salario (COP)");
            int s = int.Parse(Console.ReadLine());
              if (s< 1755606)
             {
                Console.WriteLine("Tarifa A");
             }
              else if (s >= 1755606 && s<3511212)
            {
                Console.WriteLine("Tarifa B");
            }
              else {
                Console.WriteLine("Tarifa C");

                
            }
        }
    }
}
