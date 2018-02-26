using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fatorial de: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + Factorial(n));
            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
