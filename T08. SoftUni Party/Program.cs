using System;
using System.Collections.Generic;

namespace T08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (input[0] > 47 && input[0] < 58)
                {
                    VIP.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                if (VIP.Contains(input))
                {
                    VIP.Remove(input);
                }
                else if (regular.Contains(input))
                {
                    regular.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(VIP.Count + regular.Count);

            foreach (string guest in VIP)
            {
                Console.WriteLine(guest);
            }

            foreach (string guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
