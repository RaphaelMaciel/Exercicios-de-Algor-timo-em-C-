using System;

namespace Secao6_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int p;
            int i;

            if((numero % 2) == 0)
            {
                p = numero;
                Console.WriteLine("O número é par, por tanto foi armazenado em p o valor de " + numero);
            }
            else
            {
                i = numero;
                Console.WriteLine("O número é ímpar, por tanto foi armazenado em i o valor de " + numero);
            }
        }
    }
}
