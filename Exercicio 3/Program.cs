using System;

namespace Exercicio_3
{
    class Program
    {
             static void Main(string[] args)
        {
            // Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            
            // Se quantidade &lt;= 5 o desconto será de 2%
            
            // Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
            
            // Se quantidade &gt; 10 o desconto será de 5%
            
            // Dica: utilize if / else if / else
        
            string produto;
            int quantidade;
            float preco;
            float desconto;

            Console.WriteLine("Produto comprado: ");
            produto = Console.ReadLine();

            Console.WriteLine ("Preço do produto: ");
            preco = float.Parse (Console.ReadLine());
            
            Console.WriteLine ("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            
            float total = quantidade * preco;
            
            Console.WriteLine($"O valor da compra é de: {total}");
                   
            if(quantidade <= 5){
                desconto = total * 1.02f - total;
                float totalapagar = total - desconto;
                Console.WriteLine($"O valor do seu produto é igual a {total} R$, porém com o desconto de 2%, o preço cai para {totalapagar:0.00} R$");    
            }else if(quantidade > 5 && quantidade <= 10){
                desconto = total * 1.03f - total;
                float totalapagar = total - desconto;

                Console.WriteLine($"O valor do seu produto é igual a {total} R$, porém com o desconto de 3%, o preço cai para {totalapagar:0.00} R$");    
            }else if (quantidade > 10){
                desconto = total * 1.05f - total;
                float totalapagar = total - desconto;

                Console.WriteLine($"O valor do seu produto é igual a {total} R$, porém com o desconto de 5%, o preço cai para {totalapagar:0.00} R$"); 
            }
            


        }
    }
}
