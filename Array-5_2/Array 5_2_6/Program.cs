using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            if ((n != 1) && (n != 0))
            {
                int[,] t = new int[n, n];
                Console.WriteLine("Заполните массив числами, вводя с клавиатуры, для ввода числа нажимайте \"Enter\"");
                int[] SumI = new int[n];
                int[] SumJ = new int[n];
                int SumD1 = 0;
                int SumD2 = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        t[i, j] = Convert.ToInt32(Console.ReadLine());

                        SumI[j] += t[i, j];
                        SumJ[i] += t[i, j];
                        if (i == j)
                        {
                            SumD1 += t[i, j];
                        }
                        if (i + j == n - 1)
                        {
                            SumD2 += t[i, j];
                        }

                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,3} ", t[i, j]);
                    }
                    Console.Write("SumI={0,3} ", SumI[i]);
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0,3} ", SumJ[i]);

                }
                Console.WriteLine();
                Console.WriteLine("Cуммы по диагонали {0}, {1}", SumD1, SumD2);
                if (SumD1 == SumD2)
                {
                    int k = SumD1;
                    for (int i = 0; i < n; i++)
                    {
                        if ((SumI[i] == SumI[++i]) && (SumJ[i] == SumJ[++i]) && (k == SumJ[i]))
                        {
                            Console.WriteLine("Матрица является магическим квадратом");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Матрица не является магическим квадратом");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Матрица не является магическим квадратом");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Двумерный массив не может быть создан");
                Console.ReadKey();
            }


        }
    }
}