using System;

namespace Secao6_Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                if(numero > 0)
                {
                    Console.WriteLine("O número {0} é par e positivo", numero);
                }
                else
                {
                    Console.WriteLine("O número {0} é par e negativo", numero);
                }
            }
            else
            {
                if (numero > 0)
                {
                    Console.WriteLine("O número {0} é impar e positivo", numero);
                }
                else
                {
                    Console.WriteLine("O número {0} é impar e negativo", numero);
                }
            }
        }
    }
}
