using System;

namespace Exercicio_3
{
    class Program
    {
             static void Main(string[] args)
        {
        
            string produto;
            int quantidade;
            float preco;           
            float totalApagar;

            Console.WriteLine("Produto comprado: ");
            produto = Console.ReadLine();

            Console.WriteLine ("Preço do produto: ");
            preco = float.Parse (Console.ReadLine());
            
            Console.WriteLine ("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
                              
            if(quantidade <= 5){
        
                totalApagar = Calculodesconto(preco, 0.02f);
                Console.WriteLine($"O valor do seu produto com desconto de 2% é igual a: {totalApagar:0.00} R$");    
            }else if(quantidade > 5 && quantidade <= 10){

                totalApagar = Calculodesconto(preco, 0.03f);
                Console.WriteLine($"O valor do seu produto com desconto de 3% é igual a: {totalApagar:0.00} R$");       
            }else{
                totalApagar = Calculodesconto(preco, 0.05f);
                Console.WriteLine($"O valor do seu produto com desconto de 5% é igual a: {totalApagar:0.00} R$");
            }

            float Calculodesconto (float preco, float valordesconto){
                float total = quantidade * preco;
               
                float desconto = total * valordesconto;
                
                float totalapagar = total - desconto;
                
                return totalapagar;
            }
            


        }
    }
}
