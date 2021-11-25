using System;

namespace Secao7_Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int identificacao;
            int esfera = 0;
            int limpeza = 0;
            int trocaCaboOuConector = 0;
            int QuebradoOuInutilizado = 0;
            int quantidadeMouses = 0;

            do
            {
                Console.WriteLine("1 - Necessita de esfera");
                Console.WriteLine("2 - Necessita de limpeza");
                Console.WriteLine("3 - Necessita troca do cabo ou conector");
                Console.WriteLine("4 - Quebrado ou inutilizado");
                Console.WriteLine("Digite qual o defeito!");
                identificacao = int.Parse(Console.ReadLine());
                
                switch (identificacao)
                {
                    case 1:
                        esfera += 1;
                        Console.WriteLine("Necessita de esfera");
                        quantidadeMouses++;
                        break;
                    case 2:
                        limpeza += 1;
                        Console.WriteLine("Necessita de limpeza");
                        quantidadeMouses++;
                        break;
                    case 3:
                        trocaCaboOuConector += 1;
                        Console.WriteLine("Necessita trocar o cabo ou conector");
                        quantidadeMouses++;
                        break;
                    case 4:
                        QuebradoOuInutilizado += 1;
                        Console.WriteLine("Quebrado ou inutilizado");
                        quantidadeMouses++;
                        break;
                    default:
                        Console.WriteLine("Identificação inválida");
                        break;
                }
            } while (identificacao != 0);
            Console.WriteLine("Quantidade de mouses {0}",quantidadeMouses);
            Console.WriteLine();
            Console.WriteLine("Situação                                             Quantidade        Percentual");
            Console.WriteLine("1 - Necessita de esfera                                 {0}                {1}%  ",esfera,(esfera*100)/quantidadeMouses);
            Console.WriteLine("2 - Necessita de limpeza                                {0}                {1}%  ",limpeza, (limpeza * 100) / quantidadeMouses);
            Console.WriteLine("3 - Necessita troca do cabo ou conector                 {0}                {1}%  ",trocaCaboOuConector, (trocaCaboOuConector * 100) / quantidadeMouses);
            Console.WriteLine("4 - Quebrado ou inutilizado                             {0}                {1}%  ",QuebradoOuInutilizado, (QuebradoOuInutilizado * 100) / quantidadeMouses);
        }
    }
}
