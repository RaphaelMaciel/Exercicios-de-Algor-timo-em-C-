using System;

namespace Secao3_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor em metros: ");
            double metro = Convert.ToInt32(Console.ReadLine());
            
            double converteCentimetros = metro * 100;
            
            Console.WriteLine("A quantidade em centímetros é: {0}cm", converteCentimetros);
        }
    }
}
