using System;

namespace DoCasting
{
   internal class DoCasting
   {
      static void Main()
      {
         int sum = 17;
         int count = 5;
         int intAverage = sum / count;
         Console.WriteLine(intAverage);

         double doubleAverage = sum / count;
         Console.WriteLine(doubleAverage);

         double doubleAverage2 = (double)sum / count;
         Console.WriteLine(doubleAverage2);
      }
   }
}