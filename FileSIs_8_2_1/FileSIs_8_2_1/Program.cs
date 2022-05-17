using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSIs_8_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string patch = @"E:\Диляра\Апастово";
            Print(patch, 0);
            
            Console.ReadKey();
        }
        static void Print(string patch, int level)
        {
            string[] dirs = Directory.GetDirectories(patch);
            string[] files = Directory.GetFiles(patch);

            if (dirs.Count() > 0 || files.Count() > 0)
            {
                string offset = new string('\t', level);
                foreach (string s in files)
                {
                    
                    Console.WriteLine(offset+s);
                }
                foreach (string s in dirs)
                {
                    Console.WriteLine(offset+s);
                    Print(s, level + 1);
                }
            }
        }
    }
}
