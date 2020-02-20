using System;


namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            int cont = 0;
            Random aleatorio = new Random();
            while (true)
            {
                int resultado, c = 0;

                int a = aleatorio.Next(0, 11);
                Console.WriteLine("el numero a es : " + a);
                int b = aleatorio.Next(0, 11);
                Console.WriteLine("el numero b es : " + b);
                c = a + b;
                Console.WriteLine("escriba la suma:");
                resultado = int.Parse(Console.ReadLine());
                if (resultado == c)
                {
                    Console.WriteLine("puede continuar");
                    break;
                }
                cont++;
                if (cont == 3)
                {
                    Console.WriteLine("no se ha podido iniciar el programa");
                    break;
                }
            }









        }
    }
}
