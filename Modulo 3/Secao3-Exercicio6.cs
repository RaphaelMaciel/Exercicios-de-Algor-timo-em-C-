using System;

namespace Secao3_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quanto você ganha por hora: ");
            double ganhoPorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            
            double salario = ganhoPorHora * horasTrabalhadas;
            
            Console.WriteLine("O seu salário é: R${0}", salario);
        }
    }
}
