using System;
using System.Collections.Generic;
using System.Linq;

namespace E12_KeyRevolver
{
    class KeyRevolver
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            var bulletsArr = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse);
            var locksArr = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse);
            var money = int.Parse(Console.ReadLine());

            Stack<int> bullets = AddBullets(bulletsArr);
            Queue<int> locks = AddLocks(locksArr);
            int barrelCount = 0;
            while (bullets.Count > 0 && money > 0 && locks.Count > 0)
            {
                int barrel = bullets.Pop();
                money -= bulletPrice;
                barrelCount++;

                int singleLock = locks.Peek();
                if (barrel <= singleLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (barrelCount % barrelSize == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (money > 0 && locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${money}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }

        static Queue<int> AddLocks(IEnumerable<int> locksArr)
        {
            var result = new Queue<int>();
            foreach (var item in locksArr)
            {
                result.Enqueue(item);
            }

            return result;
        }

        static Stack<int> AddBullets(IEnumerable<int> bulletsArr)
        {
            var result = new Stack<int>();
            foreach (var bullet in bulletsArr)
            {
                result.Push(bullet);
            }

            return result;
        }
    }
}
