using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
            // Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
            Console.WriteLine("Resposta tabudas: ");


            for (int z = 1; z < 11; z++){
    
          for (var i = 1; i < 11; i++)
          {
              int tabuada = z * i;
              Console.WriteLine($"{z} x {i}  = {tabuada}");
          }
          Console.WriteLine();
            }
            
        }
    }
}
