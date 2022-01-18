using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();
            
            while (input != "Revision")
            {
                string[] split = input.Split(", ");
                string shop = split[0];
                string product = split[1];
                double price = double.Parse(split[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict.Add(shop, new Dictionary<string, double>());
                }

                dict[shop].Add(product, price);

                input = Console.ReadLine();
            }

            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in dict)
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
