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
            int dado2 = 0;
            int puntaje = 0;
            int turnos = 0;
            int anterior = 0;
            int vidas = 3;
            string respuesta = "s";
            

            while (respuesta == "s" && puntaje <= 100)
            {               
                dado = aleatorio.Next(1, 7);
                puntaje += dado;
                turnos++;
                Console.WriteLine("Sacaste un : " + dado + " y tu puntaje acumulado es: " + puntaje);
              
                
                if (puntaje >= 100)
                {
                    Console.WriteLine("Ganaste");
                    break;
                }
                else
                {
                    

                    if (turnos % 2 == 0)
                    {
                        vidas -= 1;
                        Console.WriteLine("perdiste una vida");
                        if (vidas == 0)
                        {
                            Console.WriteLine("tus vidas llegaron a cero, perdiste");
                            break;
                        }
                    }
                    if (turnos % 3 == 0)
                    {
                        dado2 = aleatorio.Next(1, 7);
                        puntaje += dado2;
                        Console.WriteLine("Sacaste un : " + dado2 + " y tu puntaje acumulado es: " + puntaje);
                        if (dado == dado2)
                        {
                            Console.WriteLine("Ganaste una vida te quedan: " + vidas);
                            vidas++;
                        }

                    }
                    Console.WriteLine("¿Quieres seguir jugando?");
                    respuesta = Console.ReadLine();
                }
            }

            Console.WriteLine("Fin de el juego");
        }
    }
}