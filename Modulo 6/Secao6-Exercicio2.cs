using System;

namespace Secao6_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int a;
            int b;

            if (numero > 0)
            {
                a = numero;
                Console.WriteLine("A recebeu "+ numero);
            }
            else
            {
                b = numero;
                Console.WriteLine("B recebeu " + numero);
            }

        }
    }
}
