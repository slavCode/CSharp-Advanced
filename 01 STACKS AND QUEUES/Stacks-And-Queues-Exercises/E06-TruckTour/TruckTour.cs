using System;
using System.Collections.Generic;

namespace E06_TruckTour
{
    internal class TruckTour
    {
        static void Main()
        {
            int numOfPumps = int.Parse(Console.ReadLine());
            var pumps = new Queue<Pump>();

            for (int i = 0; i < numOfPumps; i++)
            {
                var pumpParams = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpParams[1]);
                int gas = int.Parse(pumpParams[0]);

                Pump pump = new Pump(i, distanceToNext, gas);
                pumps.Enqueue(pump);
            }

            Pump startPump = null;
            bool completeJorney = false;
            while (!completeJorney)
            {
                startPump = pumps.Dequeue();
                pumps.Enqueue(startPump);

                int gasInTank = startPump.Gas;
                while (gasInTank >= startPump.DistanceToNext)
                {
                    Pump currPump = pumps.Dequeue();
                    pumps.Enqueue(currPump);

                    gasInTank += currPump.Gas;
                    gasInTank -= currPump.DistanceToNext;

                    if (currPump == startPump)
                    {
                        completeJorney = true;
                        break;
                    }
                }

                if (completeJorney) break;
            }
            Console.WriteLine(startPump.Index);
        }

        class Pump
        {
            public int Index { get; set; }
            public int DistanceToNext { get; set; }
            public int Gas { get; set; }
            public Pump(int index, int distanceToNext, int gas)
            {
                this.Index = index;
                this.DistanceToNext = distanceToNext;
                this.Gas = gas;
            }
        }
    }
}
