using System;


namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then instantiate to zero
            float num1 = 0; float num2 = 0;

            // Display title as the C# console calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number
            Console.WriteLine("Type a number, and then press Enter");
            // Line 13: convert num1 to integer
            num1 = float.Parse(Console.ReadLine());

            while ((num1 < -100.0 || num1 > 100.0))
            {
                Console.WriteLine("Type a number (-100.0 to 100.0), and then press Enter");
                num1 = float.Parse(Console.ReadLine());
            }
            /* Accept only a number in range -100,100
            while ((num1 < -100 || num1 > 100))
            {
                Console.WriteLine("Type a number (-100 to 100), and then press Enter");
                num1 = int.Parse(Console.ReadLine());
            }

            Check for a positive num1 and max 100
            while ((num1 < 0) || (num1 > 100))
            {
                Console.WriteLine("Type a positive number (maxed 100), and then press Enter");
                num1 = int.Parse(Console.ReadLine());
            }

            Check for a positive num1
            while (num1 < 0)
            {
                Console.WriteLine("Type a positive number, and then press Enter");
                num1 = int.Parse(Console.ReadLine());
            }

            */


            // Ask the user to type the second number
            Console.WriteLine("Type another number, and then press Enter");
            // Line 18: convert num2 to integer
            num2 = float.Parse(Console.ReadLine());

            while ((num2 < -100.0 || num2 > 100.0))
            {
                Console.WriteLine("Type a number (-100.0 to 100.0), and then press Enter");
                num2 = float.Parse(Console.ReadLine());
            } 

            /* Accept only a number in range -100,100
            while ((num2 < -100 || num2 > 100))
            {
                Console.WriteLine("Type a number (-100 to 100), and then press Enter");
                num2 = int.Parse(Console.ReadLine());
            }

            Check for a positive num2 and max 100
            while ((num2 < 0) || (num2 > 100))
            {
                Console.WriteLine("Type a positive number (maxed 100), and then press Enter");
                num2 = int.Parse(Console.ReadLine());
            }

            Check num2 for a Positive number 

            while (num2 < 0)
            {
                Console.WriteLine("Type a positive number, and then press Enter");
                num2 = int.Parse(Console.ReadLine());
            }
            */

            // Ask the user to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2)); // Line 32
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                // Return text for an incorrect option entry
                default:
                    Console.WriteLine("That is an incorrect option entry, please try again.");
                    break;
            }
            // Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
