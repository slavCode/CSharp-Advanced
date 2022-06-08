using System;
using System.Collections.Generic;
using System.Linq;

public class PeriodicTable
{
    public static void Main()
    {
        int numberOfChemicalCompounds = int.Parse(Console.ReadLine());
        SortedSet<string> uniqueCompounds = new SortedSet<string>();

        for (int i = 0; i < numberOfChemicalCompounds; i++)
        {
            var currCompounds = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var compound in currCompounds)
            {
                uniqueCompounds.Add(compound);
            }
        }

        Console.WriteLine($"{string.Join(" ", uniqueCompounds)}");
    }
}
