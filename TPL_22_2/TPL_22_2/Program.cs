using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPL_22_2
{
    class Program
    {
        static int SumArray(int[] a)
        {
            int Sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Sum += a[i];
            }
            Console.WriteLine("Сумма элементов в массиве = {0}", Sum);
            return Sum;
        }
        static void MaxArray(Task task, object a1)
        {
            int[] a= (int[]) a1;
            int Max=a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>Max)
                {
                    Max = a[i];
                }
            }
            Console.WriteLine("Максимальный элемент в массиве = {0}",Max);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Object object1 = new Object();
            object1 = array;

            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                array[i] = random.Next(-1000,1000);
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();

            Task task1 = new Task(() => SumArray(array));

            Action<Task, object> actionTask = new Action<Task, object>(MaxArray); 
            Task task2 = task1.ContinueWith(actionTask,object1);

            task1.Start();
            task2.Wait();
            Console.ReadKey();
        }
    }
}
