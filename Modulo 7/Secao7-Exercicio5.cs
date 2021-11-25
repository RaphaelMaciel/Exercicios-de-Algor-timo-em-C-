using System;

namespace Secao7_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;

            do
            {
                Console.WriteLine("Digite seu usuário");
                usuario = Console.ReadLine();

                Console.WriteLine("Digite seu usuário");
                senha = Console.ReadLine();

            } while (usuario == senha);

            Console.WriteLine("Usuário e senhas cadastrados com sucesso");

        }
    }
}
