using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano que você nasceu: ");
            int anodenascimento = int.Parse(Console.ReadLine());
            
            // os valores da função precisar ser exibidos em qualquer variavel que for colocada, respectivamente.
            int retornodafuncao = IdadeVotacao(2020, anodenascimento);
            

            if(retornodafuncao >= 18){
                Console.WriteLine($"Pode votar este ano, sua idade é de {retornodafuncao} anos");
            }else{
                Console.WriteLine($"Não pode votar este ano, sua idade é de {retornodafuncao} anos");
            }
             
             // Função contem determinados valores
             int IdadeVotacao(int atual, int nascimento){
                 int idade = atual - nascimento;

                return idade;
             }
        }
    }
}
