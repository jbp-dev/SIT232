using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Score
{
   public static void Main(string[] args)
   {
      double score = 39;
      if (score >= 40)
      {
         Console.WriteLine("You passed the exam!");
      }
      else
      {
         Console.WriteLine("You failed the exam!");
      }


   }

}


/*
internal class Program
{
   static void Main()
   {
      int sum = 7;
      if (sum > 20)
      {
         Console.WriteLine("You Win ");
      }
      else
      {
         Console.WriteLine("You lose ");
      }
         Console.WriteLine("the prize ");
      
   }
}
*/