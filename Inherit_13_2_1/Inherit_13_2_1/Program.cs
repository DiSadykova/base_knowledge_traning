using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_13_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Кремлевская 33", 25, 100, 18);
            building.Print();
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding("Кремлевская 33", 25, 100, 18, 3);
            multiBuilding.Print();
            Console.ReadKey();


        }

    }
    class Building
    {
        public string AdresBuild { get; set; }
        public uint LenghtBuild { get; set; }
        public uint WidthBuild { get; set; }
        public uint HeightBuild { get; set; }
        public Building(string adresBuild, uint lenghtBuild, uint widthBuild, uint heightBuild)
        {
            AdresBuild = adresBuild;
            LenghtBuild = lenghtBuild;
            WidthBuild = widthBuild;
            HeightBuild = heightBuild;
        }
        public virtual void Print()
        {
            Console.WriteLine("Адрес здания: {0}", AdresBuild);
            Console.WriteLine("Длина здания: {0}",LenghtBuild);
            Console.WriteLine("Ширина здания: {0}", WidthBuild);
            Console.WriteLine("Высота здания: {0}", HeightBuild);
        }
    }
    sealed class MultiBuilding:Building
    {
        public uint StoreyHeight { get; set; }
        public MultiBuilding(string adresBuild, uint lenghtBuild, uint widthBuild, uint heightBuild, uint storeyHeight)
            :base(adresBuild, lenghtBuild, widthBuild, heightBuild)
        {
            AdresBuild = adresBuild;
            LenghtBuild = lenghtBuild;
            WidthBuild = widthBuild;
            HeightBuild = heightBuild;
            StoreyHeight = storeyHeight;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Этажность здания: {0}", StoreyHeight);
        }

    }
}
