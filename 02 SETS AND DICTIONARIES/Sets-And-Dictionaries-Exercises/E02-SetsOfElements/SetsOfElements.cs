using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main()
    {
        var numberOfUsers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        HashSet<string> firstSet = new HashSet<string>();
        HashSet<string> secondSet = new HashSet<string>();

        for (int i = 0; i < numberOfUsers[0]; i++)
        {
            firstSet.Add(Console.ReadLine());
        }

        for (int i = 0; i < numberOfUsers[1]; i++)
        {
            secondSet.Add(Console.ReadLine());
        }

        firstSet.IntersectWith(secondSet);
        Console.WriteLine($"{string.Join(" ", firstSet)}");
    }
}
