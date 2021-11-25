using System;

namespace Secao7_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int menor = 99999;
            double soma = 0;

            for(int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("Insira um número: ");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Número digitado: {0}.",valor);
                if (valor > maior)
                {
                    if (valor < menor)
                    {
                        menor = valor;
                    }
                    maior = valor;
                }
                soma += valor;
            }
            Console.WriteLine("O maior valor é {0} e o menor valor é {1} e a média dos valores é {2}", maior, menor, soma / 10);

        }
    }
}
