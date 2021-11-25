using System;

namespace Secao3_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite outro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            
            int soma = numero1 + numero2;
            
            Console.WriteLine("A soma dos números inseridos é: {0}", soma);
        }
    }
}
