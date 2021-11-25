using System;

namespace Secao6_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de peso pescado: ");
            double p = double.Parse(Console.ReadLine());
            double m;
            int e;

            if(p > 50)
            {
                e = Convert.ToInt32(p - 50);
                Console.WriteLine("A quantidade excedida foi de {0}kg", e);

                m = Convert.ToDouble(e * 4.00);
                Console.WriteLine("O valor da multa é: R$" + m);
            }
            else
            {
                e = 0;
                m = 0;
                Console.WriteLine("Foram excedidos {0}kg logo o valor da multa é de R${1}",e ,m);
            }

        }
    }
}
