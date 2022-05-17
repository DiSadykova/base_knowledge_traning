using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, Sum = 0 ;
            int[] array=new int[7];
            for (; i < 7; ++i)
            {
                Console.WriteLine("Введите элемент Array[{0}]", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое = {0}", Sum/7);
            Console.ReadKey();
        }
    }
}
