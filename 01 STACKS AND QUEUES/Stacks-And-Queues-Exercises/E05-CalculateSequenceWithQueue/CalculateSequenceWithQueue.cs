using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_CalculateSequenceWithQueue
{
    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var calculatedSequences = new List<Queue<int>>();

            var currentSequence = new Queue<int>();

            for (int i = 0; i <= 50; i++)
            {

                int nextNumber = number + 2;

                currentSequence.Enqueue(number);
                currentSequence.Enqueue(number + 1);
                currentSequence.Enqueue(2 * number + 1);
                currentSequence.Enqueue(nextNumber);

                number = nextNumber;
            }
        }
    }
}
