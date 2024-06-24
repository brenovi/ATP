using System;

namespace Atividade_avalitiva_quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Teobaldo = "Teobaldo";
            string Astrogildo = "Astrogildo";
            int n = 0, voto = 0, numTeob = 0, numAstro = 0, qtdTeob = 0, qtdAstro = 0, nulo = 0, branco = 0;

            Console.WriteLine("insira o número de eleitores: ");
            n = int.Parse(Console.ReadLine());

            while (n < 10)
            {
                Console.WriteLine("insira o número de eleitores: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"insira o número do candidato {Teobaldo}: ");
            numTeob = int.Parse(Console.ReadLine());
            Console.WriteLine($"insira o número do candidato {Astrogildo}: ");
            numAstro = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insira o número do seu candidato: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 0)
                {
                    branco++;
                    Console.WriteLine("Branco");
                }

                else if (voto == numTeob)
                {
                    Console.WriteLine("Candidato Teobaldo");
                    qtdTeob++;
                }
                else if (voto == numAstro)
                {
                    Console.WriteLine("Candidato Astrogildo");
                    qtdAstro++;
                }
                
                else
                {
                    nulo++;
                    Console.WriteLine("Nulo");
                }
            
            }

            if (qtdTeob == qtdAstro)
             Console.WriteLine($"O resultado da eleição terminou em empate, com o total de votos para os candidatos {Teobaldo} de {qtdTeob} e {Astrogildo} de {qtdAstro}. Contabilizados {branco} votos brancos e {nulo} votos nulos.");
             else if (qtdTeob > qtdAstro)
              Console.WriteLine($"O candidato eleito foi {Teobaldo} com {qtdTeob} votos, contra {qtdAstro} votos do {Astrogildo}. Contabilizados {branco} votos brancos e {nulo} votos nulos. ");
              else 
              Console.WriteLine($"O candidato eleito foi {Astrogildo} com {qtdAstro} votos, contra {qtdTeob} votos do {Teobaldo}. Contabilizados {branco} votos brancos e {nulo} votos nulos. ");
        }
    }
}
