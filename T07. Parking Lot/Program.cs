using System;
using System.Collections.Generic;

namespace T07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> plateCollection = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] split = input.Split(", ");

                string action = split[0];
                string plate = split[1];

                if (action == "IN")
                {
                    plateCollection.Add(plate);
                }
                else if (action == "OUT")
                {
                    //if (plateCollection.Count == 0)
                    //{
                    //    continue;
                    //}

                    plateCollection.Remove(plate);
                }

                input = Console.ReadLine();
            }

            if (plateCollection.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (string plate in plateCollection)
            {
                Console.WriteLine(plate);
            }

        }
    }
}
