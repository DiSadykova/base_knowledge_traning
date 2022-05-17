using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_23_2
{
    class Program
    {
        private static int n;

        static long Factorial(int n)
        {
            long factorialN = 1;
            for (int i = 1; i < n + 1; i++)
            {
                factorialN = factorialN * i;
            }

            return factorialN;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите целочисленное значение n для вычисления n!: ");
            n = Convert.ToInt32(Console.ReadLine());
            long k=FactorialAsync().Result;
            Console.ReadKey();

        }
        static async Task<long> FactorialAsync()
        {
            long result=await Task.Run(() => Factorial(n));
            Console.WriteLine(result);
            return result;
        }
    }
    
}
