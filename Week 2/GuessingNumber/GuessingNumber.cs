
namespace GuessingNumber
{
   public class GuessingNumber
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Welcome to the Guessing Game!");

         // single player guessing game first attempt
         //int guess = 0;
         //int number = 5; // The number to guess

         //while (true)
         //{
         //   Console.Write("Guess the number between 1 and 10: ");
         //   if (int.TryParse(Console.ReadLine(), out guess) && guess >= 1 && guess <= 10)
         //   {
         //      break;
         //   }
         //   Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
         //}
         //while (guess != number)
         //{
         //   Console.Write("Wrong. Guess again: ");
         //   if (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10)
         //   {
         //      Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
         //      continue;
         //   }
         //}
         //Console.WriteLine("You guessed the number! Well done!");

         // Single player guessing game with simple input validation
         int guess = 0;
         int number = 5; // The number to guess

         while (guess != number)
         {
            Console.Write("Guess a number between 1 and 10: ");

            if (!int.TryParse(Console.ReadLine(), out guess))
            {
               Console.WriteLine("Invalid input. Please enter a whole number.");
            }
            else if (guess < 1 || guess > 10)
            {
               Console.WriteLine("Please enter a number between 1 and 10.");
            }
            else if (guess != number)
            {
               Console.WriteLine("Wrong. Guess again.");
            }
         }
         Console.WriteLine("You guessed the number! Well done!");

         // Two players guessing game
         //int number;
         //int guess = 0;

         //Console.WriteLine("Player 1: Enter a number between 1 and 10:");

         //while (true) // Keep asking Player 1 until they enter a valid number
         //{
         //   if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 10)
         //   {
         //      break;
         //   }
         //   Console.WriteLine("Invalid input. Please enter a whole number between 1 and 10.");
         //}
         //Console.Clear();  // Clear screen so Player 2 cannot see the number

         //Console.WriteLine("Player 2: Guess Player 1's number between 1 and 10.");

         //while (guess != number) // Keep asking Player 2 until they guess correctly
         //{
         //   if (!int.TryParse(Console.ReadLine(), out guess))
         //   {
         //      Console.WriteLine("Invalid input. Please enter a whole number between 1 and 10.");
         //   }
         //   else if (guess < 1 || guess > 10)
         //   {
         //      Console.WriteLine("Please enter a whole number between 1 and 10.");
         //   }
         //   else if (guess != number) // cleaner than (guess < number || guess > number)
         //   {
         //      Console.WriteLine("Wrong. Guess again.");
         //   }
         //}
         //Console.WriteLine("You guessed the number! Well done!");

      }
   }
}
