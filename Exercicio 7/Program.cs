using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
             // 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
            // 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
            // declarado
            int[] numero = new int [16];
            Console.WriteLine("Digite 15 números: ");

              for (int i = 1; i < 16; i++){
               Console.Write($"Numero {i}: ");
               numero[i] = int.Parse(Console.ReadLine());
            }

             for (int a = 15; a > 0; a--){
                Console.Write($"{numero[a]} ");
            }
        }
    }
}
