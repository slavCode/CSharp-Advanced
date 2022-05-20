using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var evenNums = new Queue<int>(numbers);
            while (evenNums.Count > 0)
            {
                if (evenNums.Peek() % 2 == 0)
                {
                    if (evenNums.Count == 1)
                    {
                        Console.Write($"{evenNums.Dequeue()}");
                    }
                    else
                    {
                        Console.Write($"{evenNums.Dequeue()}, ");
                    }
                }
                else evenNums.Dequeue();
            }
            Console.WriteLine();
        }
    }
}
