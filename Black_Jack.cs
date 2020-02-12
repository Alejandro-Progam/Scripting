using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int inicial1 = 0;
            int inicial2 = 0;
            int puntajetotal = 0;
            int cartas = 0;
            string respuesta = "s";
            inicial1 = aleatorio.Next(1, 11);
            inicial2 = aleatorio.Next(1, 11);
            puntajetotal = inicial1 + inicial2;
            Console.WriteLine("sus dos primeras cartas son:" + " " + inicial1 + "y" + inicial2);
            Console.WriteLine("¿Desea continuar (s/n)?");
            respuesta = Console.ReadLine();
            while (respuesta == "s" && puntajetotal<21)
            {
                cartas= aleatorio.Next(1, 11);
                puntajetotal += cartas;
                if (puntajetotal > 21)
                {
                    Console.WriteLine("sacaste un:"+cartas);
                    Console.WriteLine("tu puntaje total es" +" "+ puntajetotal + " "+",lo siento has perdido.");


                }
                else if (puntajetotal == 21)
                {
                    Console.WriteLine("sacaste un: " + cartas);
                    Console.WriteLine("el corazon de las cartas esta de tu lado, haz sacado 21");
                }
                else
                {
                    Console.WriteLine("sacaste un: " + cartas);
                    Console.WriteLine("tu puntaje total es " + puntajetotal );
                    Console.WriteLine("¿Desea continuar (s/n)?");
                    respuesta = Console.ReadLine();
                }
                

            }

        }
    }
}
