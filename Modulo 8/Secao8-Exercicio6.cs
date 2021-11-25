using System;

namespace Secao8_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 10, 30, 55, 325, 12, 1, 73, 87, 200, 30 };

            Console.WriteLine("1 - Mostrar o vetor em ordem crescente.");
            Console.WriteLine("2 - Mostrar o vetor em ordem decrescente.");
            Console.WriteLine("3 - fechar o programa.");
            Console.WriteLine("Informe o código: ");
            int codigo = int.Parse(Console.ReadLine());
            

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("O vetor será exibido na ordem crescente.");
                    for (int cont = 0; cont <= 9; cont++)
                    {
                        Console.WriteLine(vetor[cont]);
                    }
                    break;
                case 2:
                    Console.WriteLine("O vetor será exibido na ordem decrescente.");
                    for (int cont = 9; cont >= 0; cont--)
                    {
                        Console.WriteLine(vetor[cont]);
                    }
                    break;
                case 0:
                    Console.WriteLine("A aplicação será encerrada.");
                    break;
            }
            
        }
    }
}
