using System;
using System.Collections.Generic;
using System.Text;

namespace радилов_1.InterfaceDuck
{
    public interface ISwim
    {
        void Swim();
    }

    public class CanSwim : ISwim
    {
      public void Swim()
        {
            Console.WriteLine("I can swim! ");
        }
    }

    public class CantSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim! ");
        }
    }
}
