using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números a serem verificados:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o número #{0}:", i + 1);
                int valor = Convert.ToInt32(Console.ReadLine());

                char sinal = VerificaSinal(valor);

                if (sinal == 'P')
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (sinal == 'N')
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é nulo.");
                }
            }
        }

        public static char VerificaSinal(int valor)
        {
            if (valor > 0)
            {
                return 'P';
            }
            else if (valor < 0)
            {
                return 'N';
            }
            else
            {
                return 'Z';
            }
        }
    }
}