using System;

namespace Secao6_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 100)
            {
                numero = 0;
                Console.WriteLine(numero);
            }
            else
            {
                Console.WriteLine(numero);
            }
        }
    }
}
