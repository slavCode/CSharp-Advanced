using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main()
    {
        var numberOfUsers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        HashSet<string> users = new HashSet<string>();
        HashSet<string> result = new HashSet<string>();
        for (int i = 0; i < numberOfUsers[0] + numberOfUsers[1]; i++)
        {
            string user = Console.ReadLine();
            int currCount = users.Count;
            users.Add(user);


            if (users.Count == currCount) result.Add(user);
        }
        Console.WriteLine($"{string.Join(" ", result)}");
    }
}
