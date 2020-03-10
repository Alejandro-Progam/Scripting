using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "olovorgo ematoma paloma,gano";
            frase = frase.ToUpper();
            char[] delimitadores = { ',', ' ' };
            string[] trozos = frase.Split(delimitadores);
            List<string> palabrasVocales = new List<string>();
            int cont = 0;
            for (int i=0; i < trozos.Length; i++)
            {
                if(trozos[i][0] =='A'|| trozos[i][0] == 'E'|| trozos[i][0] == 'I'|| trozos[i][0] == 'O'|| trozos[i][0] == 'U')
                {
                    palabrasVocales.Add(trozos[i]);
                    cont++;
                    

                }
            }
            Console.Write("las palabras de la frase que empiezan por vocal son: ");
            for (int i=0; i < palabrasVocales.Count; i++)
            {
                if ((i + 1) == palabrasVocales.Count)
                {
                    Console.Write(palabrasVocales[i]+"");
                }
                else
                {
                    Console.Write(palabrasVocales[i] + ",");

                }
            }
            Console.WriteLine("\nSe encontraron " + cont + " palabras que empiezan por vocal");


        }
    }
}
