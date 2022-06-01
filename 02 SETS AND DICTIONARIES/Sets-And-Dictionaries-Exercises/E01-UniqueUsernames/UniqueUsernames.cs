using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main()
    {
        int numberOfUsers = int.Parse(Console.ReadLine());
        HashSet<string> users = new HashSet<string>();

        for (int i = 0; i < numberOfUsers; i++)
        {
            string user = Console.ReadLine();
            users.Add(user);
        }
        Console.WriteLine($"{string.Join("\n", users)}");
    }

}
