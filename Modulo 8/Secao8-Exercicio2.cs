using System;

namespace Secao8_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = { 10, 30, 55, 325, 12, 1, 73, 87, 200, 30 };
            int[] vetor2 = { 10, 30, 55, 325, 12, 1, 73, 87, 200, 30 };
            int[] vetor3 = new int[10];

            for(int cont = 0;cont <= 9; cont++)
            {
                vetor3[cont] = vetor1[cont] + vetor2[cont];
            }
            foreach(int contaVetor in vetor3)
            {
                Console.WriteLine(contaVetor);
            }
        }
    }
}
