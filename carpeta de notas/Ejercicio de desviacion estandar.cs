using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Mikasa", "Armin", "Eren", "Bertolt" };
            double[] notas = { 2.5, 2.3, 3.5, 4.0 };

            double mayor = 0;
            int indiceMayor = 0;
            double menor = 200;
            int indiceMenor = 0;

            for(int i=0; i < nombres.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    indiceMayor = i;
                    mayor = notas[i];
                }
                else if (notas[i] < menor)
                {
                    indiceMenor = i;
                    menor = notas[i];
                }
            }
            Console.WriteLine("el mayor es: " + nombres[indiceMayor] + " ,el menor es:" + nombres[indiceMenor]);
            double sumatoria = 0;
            for(int i=0; i < notas.Length; i++)
            {
                sumatoria += notas[i];
            }
            double promedio = (sumatoria) / notas.Length;
            Console.WriteLine("el proemdio es=" + promedio);

            double de = 0;
            sumatoria = 0;
            for(int i =0; i < notas.Length; i++)
            {
                sumatoria += Math.Pow(promedio-notas[i],2);
                
                
            }
            de = Math.Sqrt(sumatoria / notas.Length);
            Console.WriteLine("la desviacion estandar es= " + de);
            menor = 200;
            indiceMenor = 0;
            double diferencia = 0;
            for (int i=0; i < notas.Length; i++)
            {
                diferencia = Math.Sqrt(Math.Pow(promedio - notas[i],2));
                if (diferencia< menor)
                {
                    indiceMenor = i;
                    menor = diferencia;
                }
            }
            Console.WriteLine("la persona menos alejada de el promedio es: " + nombres[indiceMenor]);
        }
    }
}
