using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace JSON_16_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patch = "Products.json";
            StreamReader sr = new StreamReader(patch);
            String[] stringProduct = new string[5];
            Product[] product = new Product[5];
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
               stringProduct[i] = sr.ReadLine();
                
               product[i] = JsonSerializer.Deserialize<Product>(stringProduct[i]);
                if ((i>0) && (product[i].PriceProduct > product[i - 1].PriceProduct))
                {
                    a = i;
                }
                if (i==4)
                {
                    Console.WriteLine(product[a].NameProduct);
                }
            }
            Console.ReadKey();
        }
    }
    class Product
    {
        [JsonPropertyName("codProduct")]
        public int CodProduct { get; set; }
        [JsonPropertyName("nameProduct")]
        public string NameProduct { get; set; }
        [JsonPropertyName("priceProduct")]
        public double PriceProduct { get; set; }

    }
}
