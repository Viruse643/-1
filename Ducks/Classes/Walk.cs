using System;
using System.Collections.Generic;
using System.Text;
using Ducks;

namespace Ducks.Classes
{
    public class CanWalk : Interfaces.IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I can walk");
        }
    }
    public class CantWalk : Interfaces.IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I can walk");
        }
    }
}
