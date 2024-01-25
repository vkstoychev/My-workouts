using System;

namespace _02._Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 10
            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            string input;

            do
            {
                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("Try to guess the number between 1 and 100.");
                Console.WriteLine("Write END to quit.");

                input = Console.ReadLine();

                if (input == "END") break;

                if (int.TryParse(input, out int number))
                {
                    if (targetNumber == number)
                    {
                        Console.WriteLine($"Congratulations! You guessed the correct number: {targetNumber}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect guess. Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (input != "END");

            Console.WriteLine($"You quit the program. The correct number: {targetNumber}");
        }
    }
}
