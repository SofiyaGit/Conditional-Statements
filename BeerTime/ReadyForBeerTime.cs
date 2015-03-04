using System;
using System.Globalization;

//Problem 10.* Beer Time
namespace BeerTime
{
    class ReadyForBeerTime
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a time in format “hh:mm tt”");

            string input = Console.ReadLine();

            TimeSpan start = new TimeSpan(12, 0, 0);

            TimeSpan end = new TimeSpan(03, 0, 0);
             
            DateTime formatDate = DateTime.ParseExact(input, "h:mm tt", CultureInfo.InvariantCulture);

            if (formatDate.TimeOfDay > start || formatDate.TimeOfDay < end)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
            
        }

       
    }
}
