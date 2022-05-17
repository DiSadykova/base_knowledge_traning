using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_21_2
{
    class Program
    {
        static int a = 10;
        static int b = 10;
        static int[,] gardenPlan = new int[a, b];
        static object locker = new object();

        static void Gardener1()
        {
            for (int i = 0; i < a; i++)
            {
                for (int g = 0; g < b; g++)
                {
                    if (gardenPlan[i, g] != 2)
                    {
                        gardenPlan[i, g] = 1;
                        Thread.Sleep(5);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        static void Gardener2()
        {
            lock (locker)
            {
                for (int i = a - 1; i >= 0; i--)
                {
                    for (int g = b - 1; g >= 0; g--)
                    {
                        if (gardenPlan[g, i] != 1)
                        {
                            gardenPlan[g, i] = 2;
                            Thread.Sleep(5);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener2);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardener1();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0,3} ", gardenPlan[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
