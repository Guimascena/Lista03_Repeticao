using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.WriteLine("Digite um valor positivo:");
                valor = int.Parse(Console.ReadLine());

                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                }

            } while (valor <= 0);

            Console.WriteLine($"Valor aceito: {valor}");
        }
    }
}
