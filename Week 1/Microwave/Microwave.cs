using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Microwave
{
   internal class Microwave
   {
      static void Main()
      {
   /*    {
                  Console.Write("Enter number of items to heat: ");
                  int numOfitems = Convert.ToInt32(Console.ReadLine());

                  Console.Write("Enter time to heat each item: ");
                  int heatTime = Convert.ToInt32(Console.ReadLine());

                  if (numOfitems == 1)
                  {
                     double heating1 = (double)heatTime * numOfitems;
                     Console.WriteLine("Recommended heating time is: {0}", heating1);
                  }
                  else if (numOfitems == 2)
                  {
                     double heating2 = (double)heatTime * numOfitems * 1.5;
                     Console.WriteLine("Recommended heating time is: {0}", heating2);
                  }
                  else if (numOfitems == 3)
                  {
                     double heating3 = (double)heatTime * numOfitems * 2;
                     Console.WriteLine("Recommended heating time is: {0}", heating3);
                  }
                  else if (numOfitems >= 4)
                  {
                     Console.WriteLine("Heating more than three items at once is not recommended.");
                  }
         } */

         Console.Write("Enter number of items to heat: ");
         int numOfitems = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter time to heat each item: ");
         int heatTime = Convert.ToInt32(Console.ReadLine());

         double recommendedHeatingTime = 0;

         switch (numOfitems)
         {
            case 1: recommendedHeatingTime = heatTime; break;
            case 2: recommendedHeatingTime = heatTime * 1.5 * numOfitems; break;
            case 3: recommendedHeatingTime = heatTime * 2 * numOfitems; break;
            default: Console.WriteLine("Heating more than three items at once is not recommended."); break; 
         }
         Console.WriteLine("Recommended heating time is: {0}", recommendedHeatingTime);
      }
   }
}
  