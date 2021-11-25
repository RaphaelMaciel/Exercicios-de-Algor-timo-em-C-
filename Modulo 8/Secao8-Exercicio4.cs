using System;

namespace Secao8_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 10, 30, 55, 325, 12, 1, 73, 87, 200, 30, 10, 30, 55, 325, 12, 1, 73, 87, 200, 30 };
            int somaVetor = 0;

            /*
            for(int cont = 0;cont < 20;cont++)
            {
                somaVetor += vetor[cont];
            }
            
            Console.WriteLine(somaVetor);*/
            foreach (int contaVetor in vetor)
            {
                somaVetor += contaVetor;
            }
            Console.WriteLine(somaVetor);

        }
    }
}
