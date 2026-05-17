using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta;

            do
            {
                int n;
                int valor;
                int maior = 0, menor = 0, soma = 0;
                int positivos = 0, negativos = 0;
                double media, percPositivos, percNegativos;

                do
                {
                    Console.WriteLine("Digite a quantidade de valores (maior que 0 e menor que 20):");
                    n = int.Parse(Console.ReadLine());

                    if (n <= 0 || n >= 20)
                    {
                        Console.WriteLine("Quantidade inválida!");
                    }

                } while (n <= 0 || n >= 20);

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Digite o {i}º valor:");
                    valor = int.Parse(Console.ReadLine());

                    soma += valor;

                    if (i == 1)
                    {
                        maior = valor;
                        menor = valor;
                    }
                    else
                    {
                        if (valor > maior)
                        {
                            maior = valor;
                        }

                        if (valor < menor)
                        {
                            menor = valor;
                        }
                    }

                    if (valor >= 0)
                    {
                        positivos++;
                    }
                    else
                    {
                        negativos++;
                    }
                }

                media = (double)soma / n;

                percPositivos = (double)positivos * 100 / n;
                percNegativos = (double)negativos * 100 / n;

                Console.WriteLine($"\nMaior valor: {maior}");
                Console.WriteLine($"Menor valor: {menor}");
                Console.WriteLine($"Soma dos valores: {soma}");
                Console.WriteLine($"Média aritmética: {media}");
                Console.WriteLine($"Porcentagem de positivos: {percPositivos}%");
                Console.WriteLine($"Porcentagem de negativos: {percNegativos}%");

                do
                {
                    Console.WriteLine("\nDeseja executar novamente? (S/N)");
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
