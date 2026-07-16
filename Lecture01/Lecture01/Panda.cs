using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture01
{
   public class Panda
   {
      public string name;
      public int age;
      public int weight;

      public bool is_happy;

      public Panda(string _name, int _age, int _weight)
      {
         name = _name;
         age = _age;
         weight = _weight;
      }

      public void TellAbout()
      {
         Console.WriteLine("I am Panda. My name is {0}. I am {1} years old and I weigh {2} kg.", name, age, weight);
      }


   }
}
