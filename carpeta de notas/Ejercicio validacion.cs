using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int ganador = 0, cont = 0, puntajeMax = 0; 
            string respuesta = "";
            Console.WriteLine("escriba el numero de jugadores");
            int jugadores = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Desea continuar(s/n)?");
            respuesta = Console.ReadLine();
            while(respuesta!= "s" && respuesta != "n")
            {
                Console.WriteLine("respuesta erronea");
                Console.WriteLine("Desea Continuar");
                respuesta = Console.ReadLine();
            }

            while (true)
            {
                int dado = 0, total = 0,  cont1 = 0;
                Console.WriteLine("\n\nturno del el jugador " + (cont + 1));
                while (true)
                {
                    
                    dado = aleatorio.Next(1, 7);
                    total += dado;
                    Console.Write("Sacaste un " + dado);
                    Console.Write(",tu total es: " + total);
                    if (total>= puntajeMax)
                    {
                        puntajeMax=total;
                        ganador = cont;
                    }

                    if (dado == 1)
                    {
                        cont1++;
                        if (cont1 == 3)
                        {
                            Console.WriteLine("perdiste");
                            break;
                        }
                    }
                    

                    if (total >= 100)
                    {
                        Console.WriteLine("ganaste");
                        break;
                    }
                    Console.WriteLine("\n¿Desea continuar(s/n)?");
                    respuesta = Console.ReadLine();
                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.WriteLine("respuesta erronea");
                        Console.WriteLine("Desea Continuar");
                        respuesta = Console.ReadLine();
                    }
                    if (respuesta == "n") break;

                }
                cont++;
                if (cont > jugadores)
                {
                    Console.WriteLine("fin del juego");
                    Console.WriteLine("el ganadro es el jugador numero" + ganador);
                    break;
                }
            }
        }
    }
}
