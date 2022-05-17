using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects_10_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные угла");
            Console.Write("Градусы: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cекунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            angle.ToRadians(angle.Gradus, angle.Min, angle.Sec);
            Console.ReadKey();
        }
    }
    class Angle
    {
        public int Gradus { set; get; }
        public double Rad { set; get; }
        int min;
        int sec;
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут не может быть отрицательным или больше 60");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение секунд не может быть отрицательным или больше 60");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians(int gradus, int min, int sec)
        {
            double rad = gradus * Math.PI / 180+min*Math.PI/(180*60)+sec*Math.PI/(180*60*60);
            Console.WriteLine("Угол в радианах равен {0} ", rad);
        }
    }

}



