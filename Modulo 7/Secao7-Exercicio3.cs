using System;

namespace Secao7_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cont = 100; cont <= 200; cont++)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine("{0} É ímpar!",cont);
                }
            }
        }
    }
}
