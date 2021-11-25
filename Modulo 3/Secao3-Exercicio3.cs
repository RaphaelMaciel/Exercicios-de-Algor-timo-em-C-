using System;

namespace Secao3_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int quantidadeMinima = 12;
            Console.WriteLine("A Quantidade minima é: " + quantidadeMinima);

            int quantidadeMaxima = 112;
            Console.WriteLine("A Quantidade máxima é: " + quantidadeMaxima);

            double estoqueMedio = Convert.ToDouble(quantidadeMinima + quantidadeMaxima) / 2;

            Console.WriteLine("A quantidade média de peças é: {0}", estoqueMedio);
        }
    }
}
