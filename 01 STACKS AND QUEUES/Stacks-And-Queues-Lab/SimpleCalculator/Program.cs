using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string op = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                if (op == "+") stack.Push((firstNum + secondNum).ToString());
                else if (op == "-") stack.Push((firstNum - secondNum).ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
