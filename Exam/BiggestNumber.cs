using System;

// Problem 5. The Biggest of 3 Numbers
namespace TheBiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");

            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberC = double.Parse(Console.ReadLine());

            if (numberA > numberB && numberA > numberC)
            {
                Console.WriteLine("Biggest {0}", numberA);
            }

            else if (numberB> numberA && numberB > numberC)
            {
                Console.WriteLine("Biggest {0}", numberB);
            }

            else if (numberC> numberA && numberC > numberB)
            {
                Console.WriteLine("Biggest {0}", numberC);
            }
        }
    }
}
