using System;
using System.Collections.Generic;
using System.Linq;



namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] A = { 0, 15, 12, 18, 12, 6, 3, 6, 9, 0, 6, 12, 18 };
            int[] B = { 6, 0, 12, 18, 4, 0, 6, 10, 2, 2, 12, 18, 16, 6, 14, 8 };
            int[] temp = new int[A.Length + B.Length];

            int[] todos = new int[A.Length + B.Length];
            
            //se juntan los dos conjuntos en uno solo
            for (int i=0; i < A.Length; i++)
            {
                todos[i] = A[i];
            }
            
            int j = 0;
            for (int i = A.Length; i < todos.Length; i++)
            {
                todos[i] = B[j];
                j++;
            }
            for (j = 0; j < todos.Length; j++)//Buble sort para prganizar los datos 
            {
                for(int i=0;i< todos.Length - 1; i++)
                {
                    if (todos[i] > todos[i + 1])
                    {
                        int temp2 = 0;
                        temp2 = todos[i];
                        todos[i] = todos[i + 1];
                        todos[i + 1] = temp2;
                    }
                }
            }
            //guardo todos los datos en un arreglo que no los va a tener repetidos pero le van a sobrar espacios.
            j = 0;
            for (int k = 0; k < todos.Length-1; k++)
            {
                if (todos[k] != todos[k + 1])
                {
                    temp[j] = todos[k];
                    j++;// este contador tiene el numero de datos que no son repetidos
                }

            }
            
            // aqui se pasan los datos de el temporal a un nuevo arreglo union, pero con la cantidad exacta de espacios, sin ceros sobrantes.
            int[] union = new int[j]; 
            for (int k = 0; k < j; k++)
            {
                union[k] = temp[k]; 
            }

            for (int i = 0; i < j; i++)
            {
                Console.Write(union[i] + ",");
            }

            //Hallamos la intersección con un ciclo for dentros de otro ciclo for
            //lo que hace el algoritmo es que compara el primer valor de A con todos los de B si hay un numero igual lo guarda en una lista
            j = 0;
            List<int> intersec = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                
                for (int l=0;l< B.Length; l++)
                {
                    if (A[i] == B[l])
                    {   
                        intersec.Add(A[i]);
                        j++;
                    }

                }
            }
            
            for (j = 0; j < intersec.Count; j++)//Buble sort para prganizar los datos 
            {
                for (int i = 0; i < intersec.Count - 1; i++)
                {
                    if (intersec[i] > intersec[i + 1])
                    {
                        int temp3 = 0;
                        temp3 = intersec[i];
                        intersec[i] = intersec[i + 1];
                        intersec[i + 1] = temp3;
                    }
                }
            }
            // Aqui se ponen los datos en temporal que no tendria datos repetidos pero si ceros al final

            j = 0;
            int[] tempIntersec = new int[intersec.Count];
            
            for (int i = 0; i < intersec.Count-1; i++)
            {
                if(intersec[i] != intersec[i + 1])
                {
                    tempIntersec[j] = intersec[i];
                    j++;
                }
            }
            //
            Console.WriteLine("\n\nf");
            int cont = 0;
            for (int i = 0; i < 4; i++)
            {
                
                if (intersec[intersec.Count-1] != tempIntersec[i])
                {
                    cont++;
                    
                }
                
            }
            Console.WriteLine("\n\nf");
            if (cont > 0)
            {
                tempIntersec[j ] = intersec[intersec.Count-1];
                j++;
            }
            int[] interseccion = new int[j];
            // Aqui se pasan a un arreglo pero con la cantidad de datos exactos;

            

            for (int i=0; i < j; i++)
            {
                interseccion[i] = tempIntersec[i];
            }
            Console.WriteLine("\n\n0");
            for (int i = 0; i <intersec.Count; i++)
            {
                Console.Write(intersec[i] + ",");
            }
            Console.WriteLine("\n\n0");
            for (int i = 0; i < tempIntersec.Length; i++)
            {
                Console.Write(tempIntersec[i] + ",");
            }
            Console.WriteLine("\n\n0");
            for (int i = 0; i < interseccion.Length; i++)
            {
                Console.Write(interseccion[i] + ",");
            }
            Console.WriteLine("\n\n0");
        }
    }
}
