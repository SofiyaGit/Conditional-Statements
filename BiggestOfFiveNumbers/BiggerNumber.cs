using System;

//Problem 6. The Biggest of Five Numbers
namespace BiggestOfFiveNumbers
{
    class BiggerNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");

            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberC = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number: ");

            double numberD = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberE = double.Parse(Console.ReadLine());

            if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE)
            {
                Console.WriteLine("Biggest {0}", numberA);
            }
            else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE)
            {
                Console.WriteLine("Biggest {0}", numberB);
            }
            else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE)
            {
                Console.WriteLine("Biggest {0}", numberC);
            }
            else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE)
            {
                Console.WriteLine("Biggest {0}", numberD);
            }
            else if (numberE > numberA && numberE > numberB && numberE > numberC && numberE > numberD)
            {
                Console.WriteLine("Biggest {0}", numberE);
            }
        }
    }
}
