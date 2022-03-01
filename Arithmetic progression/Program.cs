using System;
using System.Collections.Generic;

namespace Arithmetic_progression
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s, difference;
            bool isArrithmeticSequence = true;
            List<int> sequence = new List<int>();

            Console.WriteLine("Please, enter the number of elements and sequence numbers:");
            if (!int.TryParse(Console.ReadLine(), out n) || (n <= 4))
            {
                Console.WriteLine("Number of elements should be an integer number qreater than 4.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out s) || (s <= 0))
                {
                    Console.WriteLine("Sequence number should be an integer number qreater than 0.");
                    return;
                }
                sequence.Add(s);
            }

            difference = sequence[1] - sequence[0];
            for (int i = 2; i < n; i++)
            {
                if ((sequence[i] - sequence[i - 1]) != difference)
                {
                    isArrithmeticSequence = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Arithmetic progression: " + (isArrithmeticSequence ? "Yes" : "No"));
            Console.Write("Press any key to stop: ");
            Console.ReadLine();
        }
    }
}
