using System;
using System.Collections.Generic;
using System.Linq;

namespace E13_CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main()
        {
            // 88/100
            var cupsArr = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse);
            var bottlesArr = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToArray();
            Queue<int> cups = new Queue<int>(cupsArr);
            Stack<int> bottles = new Stack<int>(bottlesArr);

            int wastedWater = 0;
            int cupValue = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int bottleValue = bottles.Pop();

                if (cupValue == 0)
                {
                    cupValue = cups.Dequeue();
                }

                cupValue -= bottleValue;
                if (cupValue < 0)
                {
                    wastedWater += Math.Abs(cupValue);
                    cupValue = 0;
                }
            }

            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
