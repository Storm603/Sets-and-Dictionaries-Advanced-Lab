using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list = list.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
