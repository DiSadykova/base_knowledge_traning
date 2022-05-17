using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел, разделяя числа нажатием клавиши Enter, закончите ввод числом 0");
            int positiveNum = 0, negativeNum = 0, number;
            #region 
            do //цикл ввода и сравнения количества отрицательных и положительных чисел
            {
                number = Convert.ToInt32(Console.ReadLine());
                positiveNum = (number > 0) ? ++positiveNum : positiveNum;
                negativeNum = (number < 0) ? ++negativeNum : negativeNum;
            } while (number!=0);
            #endregion
            if (positiveNum >= negativeNum) 
            {
                if (positiveNum>negativeNum)
                {
                    Console.WriteLine("Положительных чисел больше");
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("Положительных и отрицательных чисел равное количество");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Отрицательных чисел больше");
                Console.ReadKey();
            }

        }
    }
}
