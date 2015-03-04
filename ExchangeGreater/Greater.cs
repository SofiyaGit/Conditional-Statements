using System;

//Problem 1. Exchange If Greater
namespace ExchangeGreater
{
    class Greater
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");

            float numberA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            float numberB = float.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                Console.WriteLine("The first number is {0} and the second is {1}", numberB, numberA);
            }
            else
            {
                Console.WriteLine("The first number is {0} and the second is {1}", numberA, numberB);
            }
        }
    }
}
