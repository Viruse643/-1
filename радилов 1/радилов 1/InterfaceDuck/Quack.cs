using System;
using System.Collections.Generic;
using System.Text;

namespace радилов_1.InterfaceDuck
{
    public interface IQuack
    {
        void Quack();
    }

    public class CanQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can quack! Quack!");
        }
    }

    public class CantQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack!");
        }
    }

    public class PiskQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("PI!");
        }
    }
}
