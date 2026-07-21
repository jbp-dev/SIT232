namespace Repetition
{
   internal class Repetition
   {
      static void Main(string[] args)
      {
         int sum = 0;
         double average;
         int upperbound = 100;

         //In the algorithm examples, the for, while, and do…while versions all start at 1 and stop at 100 upperbound, so they produce the same output and final results.
         //The main difference is in how each loop controls repetitions:
         //The for loop is best when the number of iterations is known in advance, because the initialisation, condition, and update are all visible in the loop header.
         //The while loop is entry‑controlled: it checks its condition before each iteration and may not execute the body at all if the condition is false initially.
         //In contrast, the do…while loop is exit‑controlled: it always executes the body at least once before checking the condition, so one iteration will occur even when the condition is false at the start (for example, if upperbound were 101).

         //for loop
         //for (int number = 1; number <= upperbound; number++)
         //{
         //   sum += number;
         //   Console.WriteLine("Current number: " + number + " the sum is " + sum);
         //}

         // while loop
         //int number = 1;
         //while (number <= upperbound)
         //{
         //   sum += number;
         //   Console.WriteLine("Current number: " + number + " the sum is " + sum);
         //   number++;
         //}

         // do while loop
         int number = 1;
         do
         {
            sum += number;
            Console.WriteLine("Current number: " + number + " the sum is " + sum);
            number++;
         } while (number <= upperbound);

         average = (double)sum / upperbound;
         
         Console.WriteLine("The sum is {0}", sum);
         Console.WriteLine("The average is {0}", average);

      }
   }
}
