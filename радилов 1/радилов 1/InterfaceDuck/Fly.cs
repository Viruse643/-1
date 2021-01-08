using System;
using System.Collections.Generic;
using System.Text;

namespace радилов_1.InterfaceDuck
{
    public interface IFly
    {
        void Fly();
    }

    public class CanFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }

    public class CantFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
 }
