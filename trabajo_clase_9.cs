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
            int anterior = 0;
            int vidas = 3;
            int unos = 0;
            int dadoespecial = 2;

            string respuesta = "s";
            string respuestaesp = "";

            while (respuesta == "s" && puntaje <= 100)
            {
                anterior = dado;
                if (dadoespecial > 0)
                {
                    Console.WriteLine("tienes: " + dadoespecial + "dados especiales, deseas utilizar uno");
                    respuestaesp = Console.ReadLine();
                }
                if (dadoespecial > 0 && respuestaesp == "s")
                {

                    if (respuesta == "s")
                    {
                        dado = aleatorio.Next(1, 13);
                        dadoespecial -= 1;
                    }

                }
                else
                {
                    dado = aleatorio.Next(1, 7);
                }
                puntaje += dado;
                turnos++;
                Console.WriteLine("Sacaste un : " + dado + " y tu puntaje es: " + puntaje);
                if ((anterior == 6 && dado == 6) && vidas < 3)
                {
                    vidas += 1;
                    Console.WriteLine("Ganaste una vida, te quedan: " + vidas);
                }

                if (puntaje >= 100)
                {
                    Console.WriteLine("Ganaste");
                    break;
                }
                else
                {
                    if (dado == 1)
                    {
                        unos++;
                        if (unos % 2 == 0)
                        {
                            vidas -= 1;
                            puntaje -= 10;
                            Console.WriteLine("perdiste 10 puntos y una vida");
                            if (vidas == 0)
                            {
                                Console.WriteLine("has quedado con cero vidas");
                                break;
                            }

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