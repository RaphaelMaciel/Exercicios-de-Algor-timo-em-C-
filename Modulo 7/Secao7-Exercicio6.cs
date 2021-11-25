using System;

namespace Secao7_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int cont = 0;
            do
            {
                int multiplicacao = valor * cont;
                Console.WriteLine("{0} x {1} = {2}", valor, cont, multiplicacao);
                cont++;
            } while (cont <= 10);
            Console.WriteLine("fim da aplicação.");
        }
    }
}
