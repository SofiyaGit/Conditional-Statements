using System;

//Problem 7. Sort 3 Numbers with Nested Ifs
namespace SortThreeNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");

            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberC = double.Parse(Console.ReadLine());

            if (numberA > numberB && numberA > numberC && numberB >= numberC)
            {
                Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
            }
            else if (numberA > numberB && numberA > numberC && numberC >= numberB)
            {
                Console.WriteLine("{0} {1} {2}", numberA, numberC, numberB);
            }

            else if (numberB > numberA && numberB > numberC && numberA >= numberB)
            {
                Console.WriteLine("{0} {1} {2}", numberB, numberA, numberC);
            }
            else if (numberB > numberA && numberB > numberC && numberB >= numberA)
            {
                Console.WriteLine("{0} {1} {2}", numberB, numberC, numberA);
            }

            else if (numberC > numberA && numberC > numberB && numberA >= numberB)
            {
                Console.WriteLine("{0} {1} {2}", numberC, numberA, numberB);
            }
            else if (numberC > numberA && numberC > numberB && numberB >= numberA)
            {
                Console.WriteLine("{0} {1} {2}", numberC, numberB, numberA);
            }
        }
    }
}
