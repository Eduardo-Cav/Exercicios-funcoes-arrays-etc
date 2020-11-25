using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
            // menor valor lido.
            Console.WriteLine("Escreva 10 números: ");
            float numeros = float.Parse(Console.ReadLine());
            
             float maiornum = numeros;

             float menornum = numeros;

         for (var i = 0; i < 9; i++)
         {
                numeros = float.Parse(Console.ReadLine());
            

                if(numeros < menornum){
                    menornum = numeros;
                }
                else if(numeros > maiornum){
                    maiornum = numeros;
                }
            }

            Console.WriteLine($"O maior numero é: {maiornum}");

            Console.WriteLine($"O menor numero é: {menornum}");
        }
    }
}
