using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_19_2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Computer> listComputers = new List<Computer>()
            {
                new Computer(){Id=1, Brand="HP OMEN 25L Desktop GT11-0008ur", ProcessorType="Intel Core i5-10400F", FrequencyProcessorInMHz=2900, RAMInGB=16, HardDiskSpaceInGB=512, VRAMInGB=6, PriceInRub=99990, NumOfCopies=31},
                new Computer(){Id=2, Brand="Lenovo Legion R5 28IMB05 90NE001VRS", ProcessorType="Intel Core i5-10400", FrequencyProcessorInMHz=2900, RAMInGB=16, HardDiskSpaceInGB=1000+512, VRAMInGB=12, PriceInRub=135990, NumOfCopies=20},
                new Computer(){Id=3, Brand="iRu Game 525 MT (1498870) Mini-Tower", ProcessorType="AMD Ryzen 5 3600", FrequencyProcessorInMHz=3600, RAMInGB=16, HardDiskSpaceInGB=1000+240, VRAMInGB=12, PriceInRub=159900, NumOfCopies=15},
                new Computer(){Id=4, Brand="DELL OptiPlex 7090 MT (7090-3237)", ProcessorType="Intel Core i7-10700", FrequencyProcessorInMHz=2900, RAMInGB=8, HardDiskSpaceInGB=256, VRAMInGB=4, PriceInRub=95566, NumOfCopies=1},
                new Computer(){Id=5, Brand="DELL OptiPlex 7080 Micro (7080-5207)", ProcessorType="Intel Core i9-10900T", FrequencyProcessorInMHz=1900, RAMInGB=16, HardDiskSpaceInGB=512, VRAMInGB=4, PriceInRub=108150, NumOfCopies=10},
                new Computer(){Id=6, Brand="X-Com CAD (Z0036106) Full-Tower", ProcessorType="Intel Core i7-10700", FrequencyProcessorInMHz=2900, RAMInGB=16, HardDiskSpaceInGB=1000+512, VRAMInGB=5, PriceInRub=134139, NumOfCopies=0},
                new Computer(){Id=7, Brand="BrandStar G2714758", ProcessorType="AMD Ryzen 5 3600", FrequencyProcessorInMHz=3600, RAMInGB=32, HardDiskSpaceInGB=2000+240, VRAMInGB=8, PriceInRub=133990, NumOfCopies=1}
            };

            Console.Write("Введите название процессора: ");
            string startString = Console.ReadLine();
            Console.WriteLine("Результаты поиска компьютеров с выбранным процессором");
            List<Computer> computers = listComputers
                .Where(c => c.ProcessorType == startString)
                .ToList();
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Id} {c.Brand} {c.ProcessorType} {c.FrequencyProcessorInMHz} {c.RAMInGB} {c.HardDiskSpaceInGB} {c.VRAMInGB} {c.PriceInRub} {c.NumOfCopies}");
            }
            Console.WriteLine();

            Console.Write("Введите объем ОЗУ в ГБ: ");
            int startInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результаты поиска компьютера с объемом ОЗУ не ниже введенного");
            List<Computer> computers2 = listComputers
                .Where(c => c.RAMInGB >= startInt)
                .ToList();
            foreach (Computer c in computers2)
            {
                Console.WriteLine($"{c.Id} {c.Brand} {c.ProcessorType} {c.FrequencyProcessorInMHz} {c.RAMInGB} {c.HardDiskSpaceInGB} {c.VRAMInGB} {c.PriceInRub} {c.NumOfCopies}");
            }
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для сортировки по возрастанию стоимости");
            Console.ReadKey();
            Console.WriteLine("Коллекция отсортирована по возрастанию стоимости");
            List<Computer> computers3 = listComputers
                .OrderBy(c => c.PriceInRub)
                .ToList();
            foreach (Computer c in computers3)
            {
                Console.WriteLine($"{c.Id} {c.Brand} {c.ProcessorType} {c.FrequencyProcessorInMHz} {c.RAMInGB} {c.HardDiskSpaceInGB} {c.VRAMInGB} {c.PriceInRub} {c.NumOfCopies}");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для группировки по типу процессора");
            Console.ReadKey();
            Console.WriteLine("Коллекция сгруппирована по типу процессора");
            var computers4 = listComputers
                .GroupBy(c => c.ProcessorType);

            foreach (IGrouping<string, Computer> c in computers4)
            {
                Console.WriteLine(c.Key);
                foreach (var t in c)
                {
                    Console.WriteLine($" {t.Id} {t.Brand} {t.ProcessorType} {t.FrequencyProcessorInMHz} {t.RAMInGB} {t.HardDiskSpaceInGB} {t.VRAMInGB} {t.PriceInRub} {t.NumOfCopies}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для проверки наличия в количестве не менее 30 штук");
            Console.ReadKey();
            bool result1 =computers3
               .Any(c => c.NumOfCopies >=30);
            if (result1)
                Console.WriteLine("Есть хотя бы один компьютер в количестве не менее 30 штук");
            else
                Console.WriteLine("Нет компьютеров в количестве не менее 30 штук");
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для определения дорогого и бюджетного");
            Console.ReadKey();
            Computer result2 = computers3
                .First();
            Console.WriteLine("Самый бюджетный компьютер: ");
            Console.WriteLine($"{result2.Id} {result2.Brand} {result2.ProcessorType} {result2.FrequencyProcessorInMHz} {result2.RAMInGB} {result2.HardDiskSpaceInGB} {result2.VRAMInGB} {result2.PriceInRub } {result2.NumOfCopies}");
            Computer result3 = computers3
                .Last();
            Console.WriteLine("Самый дорогой компьютер: ");
            Console.WriteLine($"{result3.Id} {result3.Brand} {result3.ProcessorType} {result3.FrequencyProcessorInMHz} {result3.RAMInGB} {result3.HardDiskSpaceInGB} {result3.VRAMInGB} {result3.PriceInRub} {result3.NumOfCopies}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public int FrequencyProcessorInMHz { get; set; }
        public int RAMInGB { get; set; }
        public int HardDiskSpaceInGB { get; set; }
        public int VRAMInGB { get; set; }
        public int PriceInRub { get; set; }
        public int NumOfCopies { get; set; }

    }

}
