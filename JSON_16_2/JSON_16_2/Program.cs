using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;
using System.Text.Json.Serialization;

namespace JSON_16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Код товара: ");
                int cod = Convert.ToInt32(Console.ReadLine());
                Console.Write("Название товара: ");
               
                    string name = Console.ReadLine();
                
                Console.Write("Цена товара:");
                double price = Convert.ToDouble(Console.ReadLine());
                product[i] = new Product(cod, name, price);
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)

                };

                string jsonString1 = JsonSerializer.Serialize(product[i],options);

                string patch = "Products.json";
                if (i==0)
                {
                    using (StreamWriter sw = new StreamWriter(patch))
                    {
                        sw.WriteLine(jsonString1);
                    }
                    Console.WriteLine(jsonString1);
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(patch, true))
                    {
                        sw.WriteLine(jsonString1);
                    }
                    Console.WriteLine(jsonString1);
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
        public Product(int cod, string name, double price)
        {
            CodProduct = cod;
            NameProduct = name;
            PriceProduct = price;
        }
    }
}
