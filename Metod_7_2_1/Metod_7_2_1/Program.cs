using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_7_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s;
            byte i;
            MaxSTriangle(x1, y1, z1, x2, y2, z2, out  s, out  i);
            Console.WriteLine("Треугольник с большей площадью - № {0}",i);
            Console.WriteLine("Площадь большего треугольника{0:.00}", s);
            Console.ReadKey();


        }
        static void MaxSTriangle(double x1, double y1, double z1, double x2, double y2, double z2, out double s, out byte i)
        {
            double p1 = (x1 + y1 + z1) / 2;
            double s1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
            double p2 = (x2 + y2 + z2) / 2;
            double s2 = Math.Sqrt(p2 * (p2 - x1) * (p2 - y1) * (p2 - z1));
            double d = s1 - s2;
            s = 0;
            i = 0;
            if (d > 0)
            {
                i = 1;
                s = s1;

            }
            if (d < 0)
            {
                i = 2;
                s = s2;
            }
            if (d == 0)
            {
                i = 0;
                s = s1;
            }
        }
    }
}
