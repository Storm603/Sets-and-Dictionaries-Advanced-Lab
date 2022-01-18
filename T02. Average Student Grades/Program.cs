using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dic = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < names; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!dic.ContainsKey(name))
                {
                    dic.Add(name, new List<decimal>());
                }

                dic[name].Add(grade);
            }

            foreach (var element in dic)
            {
                Console.Write(element.Key + " -> ");
                foreach (var gred in element.Value)
                {
                    Console.Write($"{gred:f2} ");   
                }
                Console.WriteLine($"(avg: {element.Value.Average():f2})");
            }
        }
    }
}
