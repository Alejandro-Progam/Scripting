using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Escriba el numero de jugadores");
            int numJugadores = int.Parse(Console.ReadLine());
            while (numJugadores > 5 || numJugadores < 0)
            {
                Console.Write("Numero erroneo,");
                Console.WriteLine("Escriba el numero de jugadores");
                numJugadores = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("¿Desea COntinuar(s/n)?");
            string respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.Write("Respuesta erronea, ");
                Console.WriteLine("¿Desea COntinuar(s/n)?");
                respuesta = Console.ReadLine();
            }
            int[] puntajeinv = new int[numJugadores];
            int i = 0;
            int ganador = 0;
            int cont = 0;
            int puntajemax = 0;
            int segundo = 40;
            int segundoJugador = 0;
            while (true)
            {
                Random aleatorio = new Random();

                Console.WriteLine("\n\n\n turno de el jugador " + (cont += 1));
                int carta1 = 0;
                int puntajetotal = 0;
                int cartas = 0;
                
                
                respuesta = "s";
                carta1 = aleatorio.Next(1, 11);
                cartas = aleatorio.Next(1, 11);
                puntajetotal = carta1 + cartas;
                puntajeinv[i] = puntajetotal;
               
                Console.WriteLine("sus dos primeras cartas son:" + " " + carta1 + "y" + cartas + ", tu puntaje total es:" + puntajetotal);
                Console.WriteLine("¿Desea continuar (s/n)?");
                respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n")
                {
                    Console.Write("Respuesta erronea, ");
                    Console.WriteLine("¿Desea COntinuar(s/n)?");
                    respuesta = Console.ReadLine();
                }
                while (respuesta == "s" && puntajetotal < 21)
                {
                    cartas = aleatorio.Next(1, 11);
                    puntajetotal += cartas;
                    puntajeinv[i] = puntajetotal;
                    
                    if (puntajetotal > 21)
                    {
                        Console.WriteLine("sacaste un:" + cartas);
                        Console.WriteLine("tu puntaje total es" + " " + puntajetotal + " " + ",lo siento has perdido.");
                        


                    }
                    else if (puntajetotal == 21)
                    {
                        Console.WriteLine("sacaste un: " + cartas);
                        Console.WriteLine("el corazon de las cartas esta de tu lado, haz sacado 21");
                        ganador = cont;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("sacaste un: " + cartas);
                        Console.WriteLine("tu puntaje total es " + puntajetotal);
                        Console.WriteLine("¿Desea continuar (s/n)?");
                        respuesta = Console.ReadLine();
                        while (respuesta != "s" && respuesta != "n")
                        {
                            Console.Write("Respuesta erronea, ");
                            Console.WriteLine("¿Desea COntinuar(s/n)?");
                            respuesta = Console.ReadLine();
                        }
                        
                    }

                }
                if (puntajetotal > puntajemax && puntajetotal < 21)
                {
                    ganador = cont;
                    puntajemax = puntajetotal;
                }
                i++;
                if ((cont) == numJugadores)
                {
                    
                    break;
                    
                }
            }
            Console.WriteLine("Fin del juego");
            int diferencia = 0;
            for ( int j=0; j < numJugadores; j++)
            {
                Console.WriteLine("\njugador número: "+(j+1)+"su puntaje es: "+puntajeinv[j]);
                diferencia =  puntajemax- puntajeinv[j];
                Console.WriteLine((j+1)+"ciclo");

                if (diferencia>0 && diferencia < segundo)
                {
                    segundo = diferencia;
                    segundoJugador = j + 1;
                    Console.WriteLine("nuevo segundo");
                }

            }
            Console.WriteLine("el ganador es el jugador número: " + (ganador ));
            if (segundoJugador == 0)
            {
                Console.WriteLine("no hubo segundo lugar");

            }
            else
            {
                Console.WriteLine("el segundo lugar es de :" + segundoJugador);
            }
                                                                                                                               

        }
    }
}
