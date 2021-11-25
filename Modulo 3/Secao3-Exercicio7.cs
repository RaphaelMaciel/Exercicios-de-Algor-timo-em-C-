using System;

namespace Secao3_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            
            double calculoPesoIdeal = (72.7 * altura) - 58;
            
            Console.WriteLine("O seu peso ideal é: {0}", calculoPesoIdeal);
        }
    }
}
