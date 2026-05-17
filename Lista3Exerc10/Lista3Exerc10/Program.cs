using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, maior = 0, soma = 0;
            double media;

            for (int i = 1; i <= 10; i++)
            {
                do
                {
                    Console.WriteLine($"Digite o {i}º valor positivo:");
                    valor = int.Parse(Console.ReadLine());

                    if (valor <= 0)
                    {
                        Console.WriteLine("Valor inválido!");
                    }

                } while (valor <= 0);

                soma += valor;

                if (i == 1 || valor > maior)
                {
                    maior = valor;
                }
            }

            media = (double)soma / 10;

            Console.WriteLine($"\nMaior valor: {maior}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética: {media}");

        }
    }
}
