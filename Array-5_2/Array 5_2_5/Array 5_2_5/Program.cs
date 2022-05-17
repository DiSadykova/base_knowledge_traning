using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N");
            int n;
            n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
         
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < n;j++)
                {
                    if ((i+j)%2!=0)
                    {
                        t[i, j] = 1;
                    }
                    else
                    {
                        t[i, j] = 0;
                    };

                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
