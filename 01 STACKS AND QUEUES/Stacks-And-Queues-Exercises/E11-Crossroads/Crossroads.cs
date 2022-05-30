using System;
using System.Collections.Generic;

namespace E11_Crossroads
{
    class Crossroads
    {
        static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int passedCarsCount = 0;

            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input != "green")
                {
                    // Add car
                    string car = input;
                    cars.Enqueue(car);
                }
                else
                {
                    // Green light
                    int currGreenLight = greenLight;
                    int remainingTime = greenLight + freeWindow;

                    while (cars.Count > 0 && currGreenLight > 0)
                    {
                        string currentCar = cars.Dequeue();
                        int carLength = currentCar.Length;
                        if (remainingTime >= carLength)
                        {
                            passedCarsCount++;
                            remainingTime -= carLength;

                            if (currGreenLight < carLength) currGreenLight = 0;
                            else currGreenLight -= carLength;
                        }
                        else
                        {
                            char hitLetter = currentCar[remainingTime];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {hitLetter}.");
                            return;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCarsCount} total cars passed the crossroads.");
        }
    }
}
