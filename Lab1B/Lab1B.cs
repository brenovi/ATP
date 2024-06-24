using System;

namespace aula5
{
    class Program
    {
        static void Main(string[] args)
        {
           int x, y,soma=0;

           Console.WriteLine("Insira um número x: ");
           x = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Insira um número y: ");
           y = Convert.ToInt32(Console.ReadLine());

          for (int i = 1; i <= y; i++)
          {
            soma = soma+x;
          }
           Console.WriteLine($"o Produto de é: {soma}");
                     
        }
    }
}