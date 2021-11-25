using System;

namespace Secao4_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario1 = 100.00;
            double ir1 = 0.00;
            double salliq1 = Salario1-ir1;

            if(salliq1>=Salario1)
            {
                Console.WriteLine("Salario líquido é maior ou igual a 100: A expressão é verdadeira");
            }
            else
            {
                Console.WriteLine("Salario líquido não é maior ou igual a 100: A expressão é falsa");
            }

            double Salario2 = 200.00;
            double ir2 = 10.00;
            double salliq2 = Salario2 - ir2;

            if (salliq2 >= Salario2)
            {
                Console.WriteLine("Salario líquido é maior ou igual a 100: A expressão é verdadeira");
            }
            else
            {
                Console.WriteLine("Salario líquido não é maior ou igual a 100: A expressão é falsa");
            }

            double Salario3 = 300.00;
            double ir3 = 15.00;
            double salliq3 = Salario3 - ir3;

            if (salliq3 == Salario3 +ir3)
            {
                Console.WriteLine("Salario líquido é igual a soma de salário + ir: A expressão é verdadeira");
            }
            else
            {
                Console.WriteLine("Salario líquido não é igual a soma de salário + ir: A expressão é falsa");
            }
        }
    }
}
