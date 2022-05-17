using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_12_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.Perimeter(5));
            Console.WriteLine(Circle.Square(7));
            Console.WriteLine(Circle.Own(5, 3, 4));
            Console.ReadKey();
        }
    }
    static class Circle
    {
        public static double cPer;
        public static double cSq;
        public static bool cOwn;
        public static double radius;

        public static double Perimeter(double radius)
        { 
            cPer = 2 * Math.PI * radius;
            return cPer;
        }
        public static double Square(double radius)
        {
            cSq = Math.PI * Math.Pow(radius, 2);
            return cSq;
        }
        public static bool Own(double radius, double x, double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            if (hypotenuse <= radius)
            {
                cOwn = true;
            }
            else
            {
                cOwn = false;
            }
            return cOwn;
        }

    }

}
