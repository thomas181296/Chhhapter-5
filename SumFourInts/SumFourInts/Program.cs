using System;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int numEntry;
            int i = 0;

            while (i < 4)
            {
                Console.WriteLine("Enter num");
                numEntry = Convert.ToInt32(Console.ReadLine());
                total = total + numEntry;
                ++i;
            }
            Console.WriteLine(total);
        }
    }
}
