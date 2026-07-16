namespace Lecture01
{

   public class Program
   {
      static void Main(string[] args)
      {
         Panda Bao = new Panda("Bao", 5, 150);
         // Bao.TellAbout();

         Panda Gao = new Panda("Gao", 3, 100);

         Keeper keeper = new Keeper();
         keeper.TalkToPanda(Bao);
         keeper.TalkToPanda(Gao);



         Console.ReadKey();
      }
   }
}
