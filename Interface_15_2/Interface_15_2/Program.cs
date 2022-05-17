using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart(4);
            arith.getNext();
            arith.getNext();
            arith.getNext();
            arith.reset();
            arith.getNext();
            arith.getNext();
            Console.WriteLine();
            GeomProgression geom = new GeomProgression();
            geom.setStart(10);
            geom.getNext();
            geom.getNext();
            geom.reset();
            geom.getNext();
            Console.ReadKey();




        }
    }
    interface iSeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    public class ArithProgression : iSeries
    {
        int SetStart;
        int getnext;
        public int getNext()
        {
            getnext = getnext + 5;
            Console.WriteLine(getnext);
            return getnext;
            
        }

        public void reset()
        {
            getnext = SetStart;
            Console.WriteLine(getnext);
        }

        public void setStart(int x)
        {
            SetStart = x;
            getnext = SetStart;
            Console.WriteLine(SetStart);
        }
    }
    public class GeomProgression : iSeries
    {
        int SetStart;
        int getnext;
        public int getNext()
        {
            getnext = getnext * 5;
            Console.WriteLine(getnext);
            return getnext;
        }

        public void reset()
        {
            getnext = SetStart;
            Console.WriteLine(getnext);
        }

        public void setStart(int x)
        {
            SetStart = x;
            getnext = SetStart;
            Console.WriteLine(SetStart);
        }
    }
}
