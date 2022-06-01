using System;
using System.Collections.Generic;
using System.Linq;

public class CountSameValuesInArray
{
    public static void Main()
    {
        var input = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse);
        var values = new Dictionary<double, int>();

        foreach (var value in input)
        {
            if (!values.ContainsKey(value)) values.Add(value, 1);
            else values[value]++;
        }

        foreach (var value in values)
        {
            Console.WriteLine($"{value.Key} - {value.Value} times");
        }
    }
}
