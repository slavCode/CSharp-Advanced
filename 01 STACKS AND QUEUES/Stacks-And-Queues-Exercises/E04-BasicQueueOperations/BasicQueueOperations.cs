using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            var commands = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            int enqueques = commands[0];
            int dequeques = commands[1];
            int peekElement = commands[2];

            var inputNumbers = Console.ReadLine()
                              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
            var numbers = new Queue<int>();

            // First command
            for (int i = 0; i < enqueques; i++)
            {
                numbers.Enqueue(inputNumbers[i]);
            }

            // Second command
            for (int i = 0; i < dequeques; i++)
            {
                numbers.Dequeue();
            }

            bool exists = numbers.Contains(peekElement);
            int smallestElement = int.MaxValue;
            if (exists) Console.WriteLine("true");
            else if (numbers.Count > 0) 
            {
                while (numbers.Count > 0)
                {
                    int currentElement = numbers.Dequeue();
                    if (smallestElement > currentElement)
                    {
                        smallestElement = currentElement;
                    }
                }

                Console.WriteLine(smallestElement);
            }
            else Console.WriteLine(0);
        }
    }
}
