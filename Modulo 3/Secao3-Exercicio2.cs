using System;

namespace Secao3_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade minima: ");
            int quantidadeMinima = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade máxima: ");
            int quantidadeMaxima = Convert.ToInt32(Console.ReadLine());

            double estoqueMedio = Convert.ToDouble(quantidadeMinima + quantidadeMaxima) / 2;
            
            Console.WriteLine("A quantidade média de peças é: {0}", estoqueMedio);
        }
    }
}
