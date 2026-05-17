using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());

            while (b <= a)
            {
                Console.WriteLine("O segundo valor deve ser maior que o primeiro.");
                Console.WriteLine("Digite novamente o segundo valor:");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Primeiro valor: {a}");
            Console.WriteLine($"Segundo valor: {b}");
        }
    }
}
