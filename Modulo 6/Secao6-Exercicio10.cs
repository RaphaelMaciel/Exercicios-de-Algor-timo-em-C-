using System;

namespace Secao6_Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a idade do nadador: ");
            int idadeNadador = int.Parse(Console.ReadLine());

            switch (idadeNadador)
            {
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Categoria Infantil-A");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Categoria Infantil-B");
                    break;
                case 12:
                case 13:
                    Console.WriteLine("Categoria Juvenil-A");
                    break;
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Categoria Juvenil-B");
                    break;
                case > 18:
                    Console.WriteLine("Categoria Adultos");
                    break;

            }
        }
    }
}
