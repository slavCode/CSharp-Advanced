using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPoatato
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int tos = int.Parse(Console.ReadLine());
            var kids = new Queue<string>(input);

            while (kids.Count > 1)
            {

                for (int i = 1; i < tos; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");

            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
