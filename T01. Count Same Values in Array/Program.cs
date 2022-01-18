using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dic = new Dictionary<double, int>();

            foreach (double element in input)
            {
                if (!dic.ContainsKey(element))
                {
                    dic.Add(element, 0);
                }

                dic[element]++;
            }

            foreach (KeyValuePair<double, int> pair in dic)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value + " times");
            }
        }
    }
}
