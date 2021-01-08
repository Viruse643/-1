using System;
using System.Collections.Generic;
using System.Text;

namespace радилов_1.InterfaceTurkey
{
    public interface IEat
    {
        void Eat();
    }

    public class CanEat : IEat
    {
        public void Eat()
        {
            Console.WriteLine("I can Eat!");
        }
    }

    public class CantEat : IEat
    {
        public void Eat()
        {
              Console.WriteLine("I can't Eat!");
        }
    }
}
