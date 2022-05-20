using System;
using System.Collections.Generic;
using System.Linq;

namespace E01_ReverseNumbersWithAStack
{
    class ReverseNumbersWithAStack
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            var reversedNumbers = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNumbers.Push(numbers[i]);
            }

            while (reversedNumbers.Count > 0)
            {
                Console.Write($"{reversedNumbers.Pop()} ");
            }

            Console.WriteLine();
        }
    }
}
