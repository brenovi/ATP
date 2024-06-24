using System;

namespace Lab2B
{
    class Program
    {
        public static bool ValidarFaixa(int n, int i = 5, int j = 10)
        {
            if (n>=i && n<=j)
            return true;
           
            else
            return false;
        }
        public static double CalcularHipotenusa(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        public static void ExibirMensagem(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Insira um valor que esteja entre 5 e 10");
                n = int.Parse(Console.ReadLine());
            if (ValidarFaixa(n) == true)
            {  for (int i = 0; i < n; i++)
            {
                double a, b;

                Console.WriteLine("Insira o valor do Cateto a: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o valor do Cateto b: ");
                b = double.Parse(Console.ReadLine());

                double hipotenusa = CalcularHipotenusa(a, b);
               
            }
            }
            else
            return;

           
         
        }
    }
}