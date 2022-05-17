using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_6_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение");
            string startString = Console.ReadLine();
            startString = startString.ToLower();
            char[] letArray = startString.ToCharArray();
            int lengthArray = letArray.Length;
            byte a = 0;
            for (int i = 0, j = (lengthArray - 1); i < lengthArray/2; i++, j--)
            {
                if (Char.IsWhiteSpace(letArray[i]))
                {
                    letArray[i] =letArray[i++];
                }
                if (Char.IsWhiteSpace(letArray[j]))
                {
                    letArray[j] = letArray[j--];
                }
                if (letArray[i] != letArray[j])
                {
                    Console.WriteLine("Строка не является палиндромом");
                    Console.ReadKey();
                    a = 1;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Строка является палиндромом");
                Console.ReadKey();
            }
        }
    }
}
