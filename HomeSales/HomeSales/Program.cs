using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string D, E, F;

            int Entry = 0;
            int totalD = 0;
            int totalE = 0;
            int totalF = 0;
            int total;
            int salesEntry = 0;

            if (Entry == 'D')
            {
                Console.WriteLine("Enter sales");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalD = totalD + salesEntry;
            }

            else if (Entry == 'E')
            {
                Console.WriteLine("Enter sales");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalE = totalE + salesEntry;
            }


            else if (Entry == 'F')
            {
                Console.WriteLine("Enter sales");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalF = totalF + salesEntry;
            }
            total = totalD + totalE + totalF;

        }
    }
}
