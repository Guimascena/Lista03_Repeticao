using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            do
            {
                Console.WriteLine("Digite o sexo (F/M):");
                sexo = char.Parse(Console.ReadLine());

                if (sexo != 'F' && sexo != 'f' &&
                    sexo != 'M' && sexo != 'm')
                {
                    Console.WriteLine("Sexo inválido!");
                }

            } while (sexo != 'F' && sexo != 'f' &&
                     sexo != 'M' && sexo != 'm');

            Console.WriteLine("Sexo aceito.");
        }
    }
}
