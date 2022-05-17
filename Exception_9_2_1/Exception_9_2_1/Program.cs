using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_9_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число. X=");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите целое число. Y=");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("     1 - сложение");
            Console.WriteLine("     2 - вычитание");
            Console.WriteLine("     3 - произведение");
            Console.WriteLine("     4 - частное");
            Console.Write("Ваш выбор: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result;
            switch (n)
            {
                case 1:
                    result = x + y;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = x - y;
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = x * y;
                    Console.WriteLine(result);
                    break;
                case 4:
                    result = x / y;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером");
                    break;
            }
            Console.ReadKey();
        }
    }
}
