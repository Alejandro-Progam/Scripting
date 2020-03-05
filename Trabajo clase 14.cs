using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "benito";
            string frase = " camelo benito benito benito";
            int posicion = 0;
            string fraseFormada = "";
            palabra = palabra.ToUpper();
            frase = frase.ToUpper();

            for(int i=0; i < (frase.Length - palabra.Length+1); i++)
            {
                fraseFormada = "";

                for (int j =0; j < palabra.Length; j++)
                {
                    if (frase[j+i]==palabra[j])
                    {
                        char letra = frase[j+i];
                        fraseFormada += letra;
                        posicion = j;
                       
                    }

                    if (fraseFormada == palabra)
                    {
                        
                        Console.WriteLine("palabra encontrada en la posicion "+i);

                    }
                }
                
                

            }

        }
    }
}
