using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_11_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k");
            double kFact = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double bFact = Convert.ToDouble(Console.ReadLine());
            LinearEquation linEq = new LinearEquation(kFact, bFact);
            linEq.Root();
            Console.ReadKey();
        }
    }
    struct LinearEquation
    {
        public double k;

        public double b;
        public LinearEquation(double kFact, double bFact)
        {
            k = kFact;
            b = bFact;
        }
        public void Root()
        {

            if (k == 0 && b == 0)
            {
                Console.WriteLine("Любое x");
            }
            if (k == 0 && b != 0)
            {
                Console.WriteLine("Решений нет");
            }
            if (k != 0)
            {
                double x = -b / k;
                Console.WriteLine(x);
            }
        }

    }

}
