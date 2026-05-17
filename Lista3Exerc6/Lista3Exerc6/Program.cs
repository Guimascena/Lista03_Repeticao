using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;

            do
            {
                Console.WriteLine("Digite um valor positivo para X:");
                x = int.Parse(Console.ReadLine());

                if (x <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                }

            } while (x <= 0);

            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());

            while (b <= a)
            {
                Console.WriteLine("B deve ser maior que A.");
                Console.WriteLine("Digite novamente o valor de B:");
                b = int.Parse(Console.ReadLine());
            }

            for (int i = b; i >= a; i--)
            {
                Console.WriteLine($"{x} x {i} = {x * i}");
            }
        }
    }
}
