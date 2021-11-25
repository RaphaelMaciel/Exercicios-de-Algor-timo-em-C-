using System;

namespace Secao6_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do funcionário: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            int n = int.Parse(Console.ReadLine());

            int e;
            double salarioPorHora = 10.00;
            double calculaSalario;
            
            if(n > 50)
            {
                e = n - 50;
                calculaSalario = ( e * (salarioPorHora * 2))+(salarioPorHora * 50 );
                Console.WriteLine("O Funcionário {0}Foram excedidas {1} horas, o valor do salário é de R${2}",c, e, calculaSalario);

            }
            else
            {
                calculaSalario = n * salarioPorHora;
                Console.WriteLine("O valor do sálário do funcionário {0} é de RS{1}.",c ,calculaSalario);
            }
        }
    }
}
