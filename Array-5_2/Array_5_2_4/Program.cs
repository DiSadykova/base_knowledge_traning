using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < n; i += 2)
            {
                int a = array[i] % 2;
                if ((a==1)&&(array[i]>0))
                {
                    k++;
                }
            }
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0}", k);
            Console.ReadKey();
        }
    }
}
