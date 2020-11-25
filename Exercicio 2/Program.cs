using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Álcool:
            //  até 20 litros, desconto de 3% por litro Álcool
            //  acima de 20 litros, desconto de 5% por litro

            //Gasolina:
            //  até 20 litros, desconto de 4% por litro Gasolina
            //  acima de 20 litros, desconto de 6% por litro

            //Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
            //da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
            //sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

            float total = 0;
            bool continuar = true;

            while(continuar == true){
                
                Console.WriteLine("Vamos ver quanto de desconto você ira ter em seu abastecimento");
                Console.Write("Digite quantos Litros deseja: ");
                float litros = float.Parse(Console.ReadLine());
                Console.Write("A, G): ");
                string tipo = Console.ReadLine();
                
                if(tipo == "a" && litros <= 20){
                    // Desconto = 3% por litro = 1L = 4,90
                    float gasolina = 4.90F; 
                    float desconto2= litros * gasolina;
                    float desconto = desconto2 * 0.03f;
                    total = desconto2 - desconto;
                    Console.WriteLine($"O valor total é de: {total}");
                }

                else if(tipo == "a" && litros > 20){
                    // Desconto = 5% por litro = 1L = 4,90
                   float gasolina = 4.90F; 
                    float desconto2= litros * gasolina;
                    float desconto = desconto2 * 0.05f;
                    total = desconto2 - desconto;
                    Console.WriteLine($"O valor total é de: {total}");
                }

                else if(tipo == "g" && litros <=20){
                    // Desconto = 4% por litro = 1L = 5,30
                   float gasolina = 5.30F; 
                    float desconto2= litros * gasolina;
                    float desconto = desconto2 * 0.04f;
                    total = desconto2 - desconto;
                    Console.WriteLine($"O valor total é de: {total}");
                }
                else if(tipo == "g" && litros > 20){
                    // Desconto = 6% por litro = 1L = 5,30
                    float gasolina = 5.30F; 
                    float desconto2= litros * gasolina;
                    float desconto = desconto2 * 0.06f;
                    total = desconto2 - desconto;
                    Console.WriteLine($"O valor total é de: {total}");
                }

                else{
                    Console.WriteLine("Informação inválida, digite novamente.");
                }

                
                Console.WriteLine("Repetir operação? ");
                string resposta = Console.ReadLine();
                
                if(resposta != "sim"){
                    continuar = false;
                    Console.WriteLine("Ok até a próxima :)");
               }else{}
            }
        }
    }
}