using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            double litros, preco, valor, valorcdesconto;            

            Console.WriteLine(" Insira a Quantidade de litros: ");
            litros = double.Parse(Console.ReadLine());
           
            Console.WriteLine(" Insira o Preço do Combustível ");
           
            preco = double.Parse(Console.ReadLine());
           
            valor = litros*preco;            
            Console.WriteLine($"Valor a pagar sem desconto: {valor}");
            if (litros >= 10 && litros <= 30) {
             valorcdesconto = valor*0.99;
             Console.WriteLine($"Valor a pagar com desconto: {valorcdesconto}");  
            } else if (litros >= 31 && litros <= 40){
                valorcdesconto = valor*0.98;
                Console.WriteLine($"Valor a pagar com desconto: {valorcdesconto}");
            } else if (litros >= 41) {
                valorcdesconto = valor*0.975;
                Console.WriteLine($"Valor a pagar com desconto: {valorcdesconto}");            
            }
       
           
        }
    }
}