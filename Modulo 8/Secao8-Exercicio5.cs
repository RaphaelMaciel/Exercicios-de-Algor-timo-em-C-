using System;

namespace Secao8_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 10, 30, 20, 13, 8, 1, 7, 5, 49, 30 };
            bool maiorCinquenta = false;
            for(int cont = 0;cont < 10; cont++)
            {
                if (vetor[cont] > 50)
                {
                    Console.WriteLine("{0} é maior que 50 e ocupa a posição {1} no vetor.", vetor[cont], cont);
                    maiorCinquenta = true;
                }
            }
            if (maiorCinquenta == false)
            {
                Console.WriteLine("Não há número maior que cinquenta no vetor.");
            }
        }
    }
}
