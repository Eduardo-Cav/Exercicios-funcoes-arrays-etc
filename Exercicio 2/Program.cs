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

            Console.WriteLine("Que tipo de combustivel deseja colocar? G - Gasolina ou A - Álcool");
            string combustivel = Console.ReadLine();
            
            Console.WriteLine("Quantos litros deseja colocar: ");
            float litros = float.Parse(Console.ReadLine());

            float precoAlcool = 4.9f; 
            float precoGasolina = 5.3f; 
            float funcaovalor;
    

            switch (combustivel.ToLower())
            {
                case "a":
                funcaovalor = valorApagar(litros, precoAlcool, 0.03f, 0.05f);
                Console.WriteLine($"O valor total a ser pago é de: {funcaovalor}");
                    break;

                case "g":
                funcaovalor = valorApagar(litros, precoGasolina, 0.4f, 0.6f);
                Console.WriteLine($"O valor total a ser pago é de: {funcaovalor}");
                break;
                default:
                    break;
            }

            float valorApagar(float litros, float preco, float perc1, float perc2){
                float descontoPorcento;
                if(litros <= 20){
                    descontoPorcento = perc1;
                }else{
                    descontoPorcento =  perc2;
                }
                
                float descontoCalculo = (litros * preco) * descontoPorcento;
                float valorBasico = (litros * preco);
                float valorTotal = valorBasico - descontoCalculo;

                return valorTotal;
            }
                
             
        }
    }
}