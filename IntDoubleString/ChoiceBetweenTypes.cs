using System;
using System.Globalization;
using System.Threading;

//Problem 9. Play with Int, Double and String
namespace IntDoubleString
{
    class ChooseBetweenTypes
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please choose a type:\n 1-->int\n 2-->double\n 3-->string ");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Console.Write("Enter a number:");

                    int number = int.Parse(Console.ReadLine());

                    number += 1;

                    Console.WriteLine(number);

                    break;
                    

                case 2: Console.Write("Enter a number:");

                    double numberDouble = double.Parse(Console.ReadLine());

                    numberDouble += 1;

                    Console.WriteLine(numberDouble);

                    break;

                
                case 3: Console.WriteLine("Enter a string:");

                    string text = Console.ReadLine();

                    Console.WriteLine("{0}\u002A", text);

                    break;
                    

            }
        }
    }
}
