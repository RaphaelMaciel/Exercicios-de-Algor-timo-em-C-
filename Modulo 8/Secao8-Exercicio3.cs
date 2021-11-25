using System;

namespace Secao8_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vetor = { 10, 30, 55, 325, 12, 1, 73, 87, 200, 30 };

            for (int cont = 9; cont >= 0; cont--)
            {
                Console.WriteLine(vetor[cont]);
            }
        }
    }
}
