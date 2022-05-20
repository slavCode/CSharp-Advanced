using System;
using System.Collections.Generic;

namespace DecimalToBinaryConverter
{
    internal class SimpleCalculator
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            while (number > 0)
            {
                int reminder = number % 2;
                stack.Push(reminder);
                number /= 2;
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
