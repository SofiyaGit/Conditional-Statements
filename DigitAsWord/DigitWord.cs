using System;

//Problem 8. Digit as Word
namespace DigitAsWord
{
    class DigitWord
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit: ");

            string input = Console.ReadLine();

            int number;

            //check if the input is correct
            if (int.TryParse(input, out number))
            {

                switch (number)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;

                    default: if ((number > 9) || number < 0)
                        {
                            Console.WriteLine("not a digit"); ;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("not a digit");
            }
            
        }
    }
}
