using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano que você nasceu: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            int anoatual = int.Parse(Console.ReadLine());

            int idade = anoatual - ano;

            if(idade < 16){
                Console.WriteLine($"Sua idade é de: {idade} anos, e você não possui idade mínima para votar este ano");
            }else{
                Console.WriteLine($"Parabéns! Você tem {idade} anos e poderá votar nesta eleição");
            }
        }
    }
}
