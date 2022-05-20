using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class Program
    {
        static void Main()
        {
            var numbers = new Stack<int>();
            var firstLine = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            foreach (var number in firstLine)
            {
                numbers.Push(number);
            }

            var secondLine = Console.ReadLine().ToLower();
            while (!secondLine.Equals("end"))
            {
                var parts = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                if (command == "add")
                {
                    int firstNum = int.Parse(parts[1]);
                    int secondNum = int.Parse(parts[2]);
                    numbers.Push(firstNum);
                    numbers.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int elementsToRemove = int.Parse(parts[1]);
                    if (numbers.Count > elementsToRemove)
                    {
                        for (int i = 0; i < elementsToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                secondLine = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
