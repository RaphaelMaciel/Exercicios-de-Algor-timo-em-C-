using System;

namespace Secao4_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 3;
            int d = 6;

            if ((a > c) && (c <= d))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            if ((a + b) > 10 || (a+b) == (c+d))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            if ((a >= c) && (d >= c))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

        }
    }
}
