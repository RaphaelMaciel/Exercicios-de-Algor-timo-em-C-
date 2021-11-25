using System;

namespace Secao8_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numero = new int[5];
            int[] numerosPares = new int[5];
            

            for (int cont = 0; cont <= 4; cont++)
            {
                Console.WriteLine("Insira um número: ");
                numero[cont] = int.Parse(Console.ReadLine());
                if(numero[cont] % 2 == 0)
                {
                    numerosPares[cont] = numero[cont];    
                }
            }
            foreach(int numerosParesCont in numerosPares)
            {
                if(numerosParesCont != 0)
                {
                    Console.WriteLine(numerosParesCont);
                }
                
            }
        }
    }
}
