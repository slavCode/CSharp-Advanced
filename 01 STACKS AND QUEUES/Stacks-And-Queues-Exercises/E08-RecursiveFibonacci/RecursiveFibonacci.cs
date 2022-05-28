using System;

namespace E08_RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        private static long[] fibonacchiNumbers;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fibonacchiNumbers = new long[n];
            long result = GetFibonacci(n);
            Console.WriteLine(result);
        }

        static long GetFibonacci(int n)
        {
            if (n < 2) return n;
            if (fibonacchiNumbers[n - 1] != 0) return fibonacchiNumbers[n - 1];
            return fibonacchiNumbers[n - 1] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
