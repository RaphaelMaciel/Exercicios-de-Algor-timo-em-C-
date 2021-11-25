using System;

namespace Secao4_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            int c = 4;

            if((a+c) > b)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            if (b >= (a+2))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            if (c == (b-a))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            if ((b+a) <= c)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            if ((c+a) > b)
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
