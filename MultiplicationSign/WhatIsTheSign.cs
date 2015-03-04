using System;

//Problem 4. Multiplication Sign
namespace MultiplicationSign
{
    class WhatIsTheSign
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");

            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            double numberC = double.Parse(Console.ReadLine());

            if (numberA* numberB * numberC > 0)
            {
                Console.WriteLine("+");
            }
            if (numberA * numberB * numberC < 0)
            {
                Console.WriteLine("-");
            }
            if (numberA * numberB * numberC == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
