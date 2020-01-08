using System;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int userEntry;
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 9999)
            {
                Console.WriteLine("You entered the right number");
            }
            else if (userEntry < 9999)
            {
                Console.WriteLine("Enter a number again");
            }
        }
    }
}
