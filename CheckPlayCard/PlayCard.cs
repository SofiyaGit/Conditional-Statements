using System;

//Problem 3. Check for a Play Card
namespace CheckPlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string compare = "2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A";

            Console.WriteLine("Character  ");

            string input = Console.ReadLine();

            // using method Contains to check a character
            if (compare.Contains(input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
