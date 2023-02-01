using System;

namespace Deliverable3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            string seriesOption = "";

            Console.WriteLine("Enter an integer value between 1 and 100: ");

            try
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput < 1 || userInput > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    return;
                }
            }

            catch (FormatException)
            {      
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Choose a series: \n1. Even numbers \n2. Odd numbers");

            try
            {
                seriesOption = Console.ReadLine();
                if (seriesOption != "Even" && seriesOption != "Odd")
                {
                    Console.WriteLine("Invalid choice. Please type Even for even numbers or Odd for odd numbers.");
                    return;
                }
            }

            catch (FormatException)

            {
                Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
                return;
            }

            string seriesName = (seriesOption == "Even") ? "even" : "odd";
            Console.WriteLine("You have selected the " + seriesName + " series. The numbers between 0 and " + userInput + " are:");

            if (seriesOption == "Even")
            {
                for (int i = 0; i <= userInput; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i = 1; i <= userInput; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}