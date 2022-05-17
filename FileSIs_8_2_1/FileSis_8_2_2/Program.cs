using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSis_8_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "strRandomNumber.txt";
            double[] numRandom = new double[10];
            Random random = new Random();
            //double controlSum = 0;
            for (int i = 0; i < 10; i++)
            {
                numRandom[i] = random.Next();
                //controlSum += numRandom[i];
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(numRandom[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path))
                for (int i = 0; i < 10; i++)
                {
                    numRandom[i] = Convert.ToDouble(sr.ReadLine());
                }
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += numRandom[i];
            }
            Console.WriteLine(sum);
            //Console.WriteLine(controlSum);
            Console.ReadKey();
        }
    }
}
