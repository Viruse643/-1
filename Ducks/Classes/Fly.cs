using System;
using System.Collections.Generic;
using System.Text;
using Ducks;

namespace Ducks.Classes
{
    public class CanFly : Interfaces.IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
    public class CantFly : Interfaces.IFly
    {
        public void Fly()
        {
            Console.WriteLine("I cant fly");
        }
    }
}
