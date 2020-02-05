using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba la cantidad de votos por a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la cantidad de votos por b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la cantidad de votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la cantidad de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la poblacion total");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba el porcentaje de personas mayores de edad");


            double porcentaje = (double.Parse(Console.ReadLine()))/100.0;
            
            double mayor = poblacion * porcentaje;
            bool A = (a + b + blancos + anulados) > poblacion;
            bool B = (a - b) < (a + b + blancos + anulados) * 0.1;
           
            bool C = (a + b + blancos + anulados) < (poblacion)*0.3;
            
            if((A||B)&& C)
            {
                Console.WriteLine("las elecciones deben hacerse de nuevo");
            }
            else
            {
                if (a > b) Console.WriteLine("El ganador es a");
                else if (a < b) Console.WriteLine("El ganador es b ");

            }

            


        }
    }
}
    