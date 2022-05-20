using System;
using System.Collections.Generic;
using System.Linq;

namespace Е02_BasicStackOperations
{
    internal class BasicStackOperations
    {
        static void Main()
        {
            var commands = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            int pushes = commands[0];
            int pops = commands[1];
            int peekElement = commands[2];

            var inputNumbers = Console.ReadLine()
                              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
            var numbers = new Stack<int>();

            // First command
            for (int i = 0; i < pushes; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            // Second command
            for (int i = 0; i < pops; i++)
            {
                numbers.Pop();
            }

            bool exists = numbers.Contains(peekElement);
            if (exists) Console.WriteLine("true");
            else if (numbers.Count > 0) Console.WriteLine(numbers.Pop());
            else Console.WriteLine(0);
        }
    }
}
