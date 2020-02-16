using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0;
            int puntaje = 0;
            int turnos = 0;
            int cont10 = 0;
            int cont12 = 0;
            string respuesta = "s";

            while ( respuesta == "s" && puntaje <= 100)
            {
                dado = aleatorio.Next(1, 13);
                puntaje += dado;
                turnos++;
                Console.WriteLine("Sacaste un : " + dado + " y tu puntaje es: " + puntaje);
                if (turnos > 3)
                {
                    if (dado % 2 == 1)
                    {
                        respuesta = "n";
                    }
                    else
                    {
                        if (dado == 12 || dado == 10)
                        {

                            if (dado == 12)
                            {
                                cont12 = 2;
                            }
                            else cont12 -= 1;
                            if (dado == 10)
                            {
                                cont10 = 1;
                            }
                            else cont10 = 0;

                            if (cont12 == 1 && cont10 == 1)
                            {
                                Console.WriteLine("haz ganado");
                                break;
                            }
                        }
                        
                        Console.WriteLine("¿Quieres seguir jugando?");
                        respuesta = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("¿Quieres seguir jugando?");
                    respuesta = Console.ReadLine();
                }

            }
            Console.WriteLine("Fin de el juego");
        }
    }
}
