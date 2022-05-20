using System;
using System.Collections.Generic;

namespace Supermarket
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var names = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (names.Count > 0) Console.WriteLine(names.Dequeue());
                }
                else
                {
                    names.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
