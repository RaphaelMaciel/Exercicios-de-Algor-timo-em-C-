using System;

namespace Secao7_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cont = 0; cont <= 100; cont++)
            {
                if (cont % 10 != 0)
                {
                    Console.WriteLine(cont);
                }
                else
                {
                    Console.WriteLine("{0} É multiplo de 10",cont);
                }
                
            }
        }
    }
}
