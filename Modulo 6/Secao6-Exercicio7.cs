using System;

namespace Secao6_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quarto número: ");
            double n4 = double.Parse(Console.ReadLine());

            double quadrado1 = n1 * n1;
            double quadrado2 = n2 * n2;
            double quadrado3 = n3 * n3;
            double quadrado4 = n4 * n4;

            if(quadrado3 >= 1000)
            {
                Console.WriteLine("O quadrado de {0} é {1}", n3, quadrado3);
            }
            else
            {
                Console.WriteLine("O quadrado de {0} é {1}, de {2} é {3} e de {4} é {5}",n1, quadrado1 ,n2 ,quadrado2 ,n4 ,quadrado4);
            }
        }
    }
}
