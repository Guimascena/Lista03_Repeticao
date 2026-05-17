using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta;

            do
            {
                int n;
                int fatorial = 1;

                do
                {
                    Console.WriteLine("Digite um valor não negativo:");
                    n = int.Parse(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Valor inválido!");
                    }

                } while (n < 0);

                for (int i = n; i >= 1; i--)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"Fatorial de {n} = {fatorial}");

                do
                {
                    Console.WriteLine("Deseja realizar outro cálculo? (S/N)");
                    resposta = char.Parse(Console.ReadLine());

                    if (resposta != 'S' && resposta != 's' &&
                        resposta != 'N' && resposta != 'n')
                    {
                        Console.WriteLine("Resposta inválida!");
                    }

                } while (resposta != 'S' && resposta != 's' &&
                         resposta != 'N' && resposta != 'n');

            } while (resposta == 'S' || resposta == 's');
        }
    }
}
