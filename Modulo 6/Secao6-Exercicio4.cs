using System;

namespace Secao6_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu genero entre Masculino ou Feminino: ");
            string genero = Console.ReadLine().ToLower();

            double PesoIdeal;

            if(genero == "masculino")
            {
                PesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("Seu peso ideal é: "+PesoIdeal);
            }
            else if(genero == "feminino")
            {
                PesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("Seu peso ideal é: "+PesoIdeal);
            }
            else
            {
                Console.WriteLine("Genero não reconhecido, finalizando execução.");
            }
        }
    }
}
