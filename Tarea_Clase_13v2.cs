using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 12, 18, 12, 6, 3, 6, 9, 0, 6, 12, 18 };
            int[] B = { 6, 0, 12, 18, 4, 0, 6, 10, 2, 2, 12, 18, 16, 6, 14, 8 };
            List<int> todos = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                todos.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                todos.Add(B[i]);
            }
            for (int i = 0; i < todos.Count; i++)
            {
                for (int j = 0; j < todos.Count - 1; j++)
                {
                    if (todos[j] > todos[j + 1])
                    {
                        int temp = 0;
                        temp = todos[j];
                        todos[j] = todos[j + 1];
                        todos[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < todos.Count; i++)
            {

            }
            List<int> union = new List<int>();
            for (int i = 0; i < todos.Count - 1; i++)
            {
                if (todos[i] != todos[i + 1])
                {
                    union.Add(todos[i]);
                }

            }
            if (union[union.Count - 1] != todos[todos.Count - 1])
            {

                union.Add(todos[todos.Count - 1]);
            }
            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i] + ",");

            }
            //interseccioón 
            List<int> interseccion = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        interseccion.Add(A[i]);
                    }
                }
            }
            for (int i = 0; i < interseccion.Count; i++)
            {
                for (int j = 0; j < interseccion.Count - 1; j++)
                {
                    if (interseccion[j] > interseccion[j + 1])
                    {
                        int temp = 0;
                        temp = interseccion[i];
                        interseccion[j] = interseccion[j + 1];
                        interseccion[j + 1] = temp;


                    }
                }

            }
            List<int> intersecciontrue = new List<int>();
            for (int j = 0; j < interseccion.Count - 1; j++)
            {
                if (interseccion[j] != interseccion[j + 1])
                {
                    intersecciontrue.Add(interseccion[j]);
                }
            }
            if (interseccion[interseccion.Count - 1] != intersecciontrue[intersecciontrue.Count - 1])
            {

                intersecciontrue.Add(interseccion[interseccion.Count - 1]);
            }
            Console.Write("\n\n");

            for (int i = 0; i < intersecciontrue.Count; i++)
            {
                Console.Write(intersecciontrue[i] + ",");
            }
            //copia
            List<int> copia = new List<int>();
            List<int> complemento = new List<int>();
            for (int i = 0; i < union.Count; i++)
            {
                copia.Add(union[i]);
            }
            //   for (int i=0; i < (30 - union.Count); i++)
            //   {
            //copia.Add(0);
            //}
            List<int> faltantes = new List<int>();
            int w = 0;
            for (int i = 0; i <= 30; i++)
            {
                if (copia[w] != i)
                {
                    complemento.Add(i);
                    if (w < copia.Count - 1)
                    {
                        w++;
                    }


                }
            }
            for (int i = 0; i < copia.Count; i++)
            {
                for (int j = 0; j < copia.Count - 1; j++)
                {
                    if (copia[j] > copia[j + 1])
                    {
                        int temp = 0;
                        temp = copia[j];
                        copia[j] = copia[j + 1];
                        copia[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < complemento.Count; i++)
            {
                Console.Write(complemento[i] + ",");
            }

        }
    }
}