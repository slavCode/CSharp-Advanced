using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniParty
{
    public static void Main()
    {
        string input = Console.ReadLine();
        HashSet<string> guests = new HashSet<string>();
        HashSet<string> vipGuests = new HashSet<string>();

        while (input != "PARTY")
        {
            if (input.Count() == 8)
            {
                bool isVip = IsVip(input[0]);
                if (isVip) vipGuests.Add(input);
                else guests.Add(input);
            }

            input = Console.ReadLine();
        }

        while (input != "END")
        {
            bool isVip = IsVip(input[0]);
            if (isVip) vipGuests.Remove(input);
            else guests.Remove(input);

            input = Console.ReadLine();
        }

        Console.WriteLine($"{guests.Count + vipGuests.Count}");
        if (vipGuests.Any())
        {
            Console.WriteLine($"{string.Join("\n", vipGuests)}");
        }
        if (guests.Any())
        {
            Console.WriteLine($"{string.Join("\n", guests)}");
        }
    }
    private static bool IsVip(char letter)
    {
        return Char.IsDigit(letter);
    }
}
