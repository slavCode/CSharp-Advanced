using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E09_StackFibonacci
{
     class StackFibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<long> fibonacciNums = new Stack<long>();
            AddFirstTwoFibonacciNums(fibonacciNums);

            for (int i = 2; i <= n; i++)
            {
                var first = fibonacciNums.Pop();
                var second = fibonacciNums.Peek();
                var current = first + second;
                fibonacciNums.Push(first);
                fibonacciNums.Push(current);
            }

            Console.WriteLine(fibonacciNums.Pop());
        }

        private static void AddFirstTwoFibonacciNums(Stack<long> fibonacciNums)
        {
            fibonacciNums.Push(1);
            fibonacciNums.Push(1);
        }
    }
}
