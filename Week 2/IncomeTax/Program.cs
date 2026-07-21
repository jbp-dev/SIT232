namespace IncomeTax
{
   internal class IncomeTax
   {
      static void Main()
      {
         Console.Write("Enter taxable income: ");
         double number = Convert.ToDouble(Console.ReadLine());
         if (number <= 6000)
         {
            Console.WriteLine("Your tax payable is: Nil");
         }
         else if (number > 6000 && number <= 37000)
         {
            Console.WriteLine($"Your tax payable is: ${0.15 * (number - 6000)}");
         }
         else if (number > 37000 && number <= 80000)
         {
            Console.WriteLine($"Your tax payable is: ${4650 + 0.30 * (number - 37000)}");
         }
         else if (number > 80000 && number <= 180000)
         {
            Console.WriteLine($"Your tax payable is: ${17550 + 0.37 * (number - 80000)}");
         }
         else if (number > 180000)
         {
            Console.WriteLine($"Your tax payable is: ${54550 + 0.45 * (number - 180000)}");
         }
      }
   }
}
