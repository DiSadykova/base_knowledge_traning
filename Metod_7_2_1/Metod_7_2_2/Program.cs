using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_7_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=Convert.ToDouble(Console.ReadLine());
            double p, v;
            Volume(a, out p, out v);
            Console.WriteLine("Площадь куба = {0:.00}", p);
            Console.WriteLine("Объем куба = {0:.00}", v);
            Console.ReadKey();
        }
        static void Volume(double a, out double p, out double v)
        {
            a = Math.Abs(a);
            p = a * a * 6;
            v = a * a * a;
        }
    }
}
