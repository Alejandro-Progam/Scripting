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
            string[] nombres = new string[numJugadores];

            for (int j = 0; j < numJugadores; j++)
            {
                Console.WriteLine("escriba el nombre de el jugador");
                nombres[j] = Console.ReadLine();

            }
            Console.WriteLine("¿Desea Continuar(s/n)?");
            string respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.Write("Respuesta erronea, ");
                Console.WriteLine("¿Desea COntinuar(s/n)?");
                respuesta = Console.ReadLine();
            }
            int[] puntajeinv = new int[numJugadores];
            int i = 0;
            
            int cont = 0;
            string tempNombres = "";
            int indiceGanador = 0;
            
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
               
                i++;
                if ((cont) == numJugadores)
                {
                    break;
                }
            }

            
           
            for (int j = 0; j < puntajeinv.Length; j++)
            {
                for(int k =0; k < (puntajeinv.Length - 1); k++)
                {
                    int temp = 0;
                    if ((puntajeinv[k] - puntajeinv[k + 1])>0)
                    {
                        temp = puntajeinv[k];
                        puntajeinv[k] = puntajeinv[k + 1];
                        puntajeinv[k + 1] = temp;
                        tempNombres = nombres[k];
                        nombres[k] = nombres[k + 1];
                        nombres[k + 1] = tempNombres;
                    }
                }

            }
            
            Console.WriteLine("Fin del juego");
            for(int l=0;l<puntajeinv.Length;l++)
            {
                
                if (puntajeinv[l] <= 21)
                {
                    l = indiceGanador;
                }
                l++;
            }
            Console.WriteLine("el ganador es el jugador número: " + nombres[(indiceGanador)]);

            Console.WriteLine("el segundo lugar es" + nombres[(indiceGanador-1)]);
           
            

        }
    }
}