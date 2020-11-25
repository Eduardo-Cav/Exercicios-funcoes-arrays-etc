using System;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
            // lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
            // pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
            // entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
            bool repeat = true;
            string[] nomes = new string[11];

            Console.WriteLine("Digite 10 nomes: ");

            for(var i = 1; i < 11; i++){
                Console.Write("Nome " + i + ": ");
                nomes[i] = Console.ReadLine();
            }

            while(repeat == true){
                Console.WriteLine("Digite um nome: ");
                Console.Write("Nome: ");
                string othername = Console.ReadLine();

                foreach(var nome in nomes){
                    if(nome == othername){
                        Console.WriteLine($"O nome {othername} foi encontrado.");
                        break;
                    }
                }

                Console.WriteLine("Quer tentar de novo? ");
                string otherrepeat = Console.ReadLine();
                if(otherrepeat != "sim"){
                    Console.WriteLine("Até a próxima!");
                    break;
                  }else{}
            }
        }
    }
}