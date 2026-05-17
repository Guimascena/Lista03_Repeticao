using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 3; i <= 30; i++)
            {
                c = a + b;

                Console.WriteLine(c);

                a = b;
                b = c;
            }
        }
    }
}
