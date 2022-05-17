using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число А");
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число B");
            uint b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число С");
            uint c = Convert.ToUInt32(Console.ReadLine());
            uint i = 0, k = 0, d = a;
            if (a >= c && d >= c)

            {
                while (d >= c)
                {
                    d = d - c;
                    i = i + 1;
                }
                d = b;

                while (d >= c)
                {
                    d = d - c;
                    k = k + i;
                }
                Console.WriteLine("В прямоугольнике с размерами A*B умещается {0} квадратов со стороной C", k);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("В прямоугольнике с размерами A * B умещается 0 квадратов со стороной C");

            }
        }
    }
}
