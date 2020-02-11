using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba su salario");
            int sal = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba 0 si es dependiente y 1 si es independiente");
            int contrato = int.Parse(Console.ReadLine());
            int smmlv = 877803, prima = 0;
            double pension = 0, arl = 0, eps = 0, salreal = 0, salanual = 0;
            double bas = sal * 0.4;
            if (bas <= smmlv)
            {
                bas = smmlv;
            }
            switch (contrato)
            {
                case 0:
                    eps = bas * 0.04;
                    pension = bas * 0.04;
                    salanual = (salreal) * 12 + sal;
                    prima = sal;
                    break;
                case 1:
                    Console.WriteLine("escriba el numero de arl");
                    arl = int.Parse(Console.ReadLine());
                    eps = bas * 0.125;
                    pension = bas * 0.16;
                    switch (arl)
                    {
                        case 1:
                            arl = bas * (0.522 / 100.0);
                            break;
                        case 2:
                            arl = bas * (1.044 / 100);
                            break;
                        case 3:
                            arl = bas * (2.436 / 100);
                            break;
                        case 4:
                            arl = bas * (4.350 / 100);
                            break;
                        case 5:
                            arl = bas * (6.960 / 100);
                            break;

                    }
                    break;
            }
            Console.WriteLine("deducciones" + eps + arl + pension); 
            salreal = sal - (eps + pension + arl);
            Console.WriteLine("su salario real mensual es: " + salreal);
            salanual = (salreal) * 12 + prima;
            Console.WriteLine("su salario anual es: " + salanual);

        }
    }
}


















