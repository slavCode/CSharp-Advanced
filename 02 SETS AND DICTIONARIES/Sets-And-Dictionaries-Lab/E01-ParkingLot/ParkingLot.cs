using System;
using System.Collections.Generic;

internal class ParkingLot
{
    public static void Main()
    {
        var input = Console.ReadLine();
        HashSet<string> cars = new HashSet<string>();

        while (input != "END")
        {
            var args = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string direction = args[0];
            string carPlate = args[1];

            switch (direction)
            {
                case "IN":
                    cars.Add(carPlate);
                    break;
                case "OUT":
                    cars.Remove(carPlate);
                    break;
            }

            input = Console.ReadLine();
        }

        if (cars.Count > 0)
        {
            Console.WriteLine($"{string.Join("\n", cars)}");
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}

