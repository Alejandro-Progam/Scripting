using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int dado1 = 0;
            int dado2 = 0;
            int total = 0;
            int cont6 = 0;
            int cont = 0;
            int contdoble = 0;
           
            string respuesta = "s";
            double porcentaje = 0;
            while (respuesta == "s")
            {

                dado1 = 2;
                dado2 = 2;
                total += dado2 + dado1;
                cont++;
                Console.WriteLine("sacaste :" + dado1 + " y " + dado2 + "=" + total);

                if ((dado2 + dado1) >= 6)
                {
                    cont6++;
                }
                
                if (dado1 == dado2)
                {
                    contdoble++;
                    if (contdoble == 3)
                    {
                        Console.WriteLine("Ganaste Crack");
                        respuesta = "n";
                        break; 
                    }
                }
                else
                {
                    contdoble = 0;

                }
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("perdiste Crack");
                    respuesta = "n";
                }
                else if (total >= 100)
                {
                    
                    respuesta = "n";
                    Console.WriteLine("Ganaste Crack");

                }
                else
                {
                    Console.WriteLine("¿Quieres seguir continuando Crack(s/n)?");
                    respuesta = Console.ReadLine();
                    
                }
                

            }
            porcentaje = cont6 * 100 / ((double)cont);
            Console.WriteLine("sacaste un porcentaje de mayores que seis = " + porcentaje+"%");
            Console.WriteLine("fin del juego");


        }
    }
}