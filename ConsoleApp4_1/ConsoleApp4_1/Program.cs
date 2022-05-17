using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N>0");
            Int32 number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Int32 numSecPow = (Int32)Math.Pow(number, 2);
                for (Int32 y = 1, x = 0, i = -1; (y * 2 - 1) + x <= numSecPow; i += 2, x += i, y++)
                {
                    Int32 u = (y * 2 - 1) + x;
                    Console.WriteLine("{0}", u);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Данные не соответствуют условию");
            }
        }
    }
}
