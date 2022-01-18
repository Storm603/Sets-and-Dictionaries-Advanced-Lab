using System;
using System.Collections.Generic;

namespace T06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> collection = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                collection.Add(name);
            }

            foreach (string name in collection)
            {
                Console.WriteLine(name);
            }
        }
    }
}
