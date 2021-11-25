using System;

namespace Secao7_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int maiorNumero = 0;
            int valor = int.Parse(Console.ReadLine());

            while(valor != 0)
            {
                Console.WriteLine("Número informado foi o {0}",valor);
                if (maiorNumero < valor)
                {
                    maiorNumero = valor;
                    Console.WriteLine("O maior número até o momento é: {0}", maiorNumero);
                }
                else
                {
                    Console.WriteLine("{0} é menor que o maior número já informado {1}",valor, maiorNumero);
                }
                valor = int.Parse(Console.ReadLine());
            }

        }
    }
}
