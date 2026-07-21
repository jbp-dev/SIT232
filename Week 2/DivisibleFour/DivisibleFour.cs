namespace DivisibleFour
{
   internal class DivisibleFour
   {
      static void Main(string[] args)
      {
         
         Console.Write("Please enter a positive integer: ");
         int n = Convert.ToInt32(Console.ReadLine());

         for (int i = 0; i <= n; i += 4)
         {
            if (i % 4 == 0 && i % 5 != 0)
            {
               Console.WriteLine(i);
            }
         }
      }
   }
}
