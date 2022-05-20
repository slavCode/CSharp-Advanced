using System;
using System.Collections.Generic;
using System.Linq;

namespace E03_MaximumElement
{
    class MaximumElement
    {
        static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            var elements = new Stack<int>();
            var maxElements = new Stack<int>();
            maxElements.Push(int.MinValue);

            for (int i = 0; i < numberOfOperations; i++)
            {
                var query = Console.ReadLine()
                           .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();
                var command = query[0];
                switch (command)
                {
                    case "1":
                        int elementToPush = int.Parse(query[1]);
                        elements.Push(elementToPush);
                        if (elementToPush >= maxElements.Peek())
                        {
                            maxElements.Push(elementToPush);
                        }
                        break;
                    case "2":
                        int elementToPop = elements.Pop();
                        if (elementToPop == maxElements.Peek())
                        {
                            maxElements.Pop();
                        }
                        break;
                    case "3":
                        Console.WriteLine(maxElements.Peek());
                        break;
                }
            }
        }
    }
}
