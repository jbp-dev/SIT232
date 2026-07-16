using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture01
{
   public class Keeper
   {
      public string name;

      public void TalkToPanda(Panda panda)
      {
         panda.TellAbout();
      }
   }
}
