using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var letters = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            if (!letters.ContainsKey(letter))
            {
                letters.Add(letter, 1);
            }
            else letters[letter]++;
        }

        foreach (var letter in letters)
        {
            Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
        }
    }
}
