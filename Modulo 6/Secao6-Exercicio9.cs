using System;

namespace Secao6_Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o índice de poluição medido: ");
            double indicePoluicao = double.Parse(Console.ReadLine());

            if(indicePoluicao >= 0.30 && indicePoluicao <= 0.40)
            {
                Console.WriteLine("As industrias do grupo 1 devem paralisar suas operações.");
            }
            else if(indicePoluicao >= 0.40 && indicePoluicao <= 0.50)
            {
                Console.WriteLine("As industrias do grupo 1 e 2 devem paralisar suas operações.");
            }
            else if (indicePoluicao >= 0.50)
            {
                Console.WriteLine("Todas as industrias devem paralisar suas operações.");
            }
            else
            {
                Console.WriteLine("Indice de poluição permanece normal.");
            }
        }
    }
}
