using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;


namespace Ducks.Classes
{
    public class CanFlyTurkey : IFlyTurkey
    {
        public void FlyTurkey()
        {
            Console.WriteLine("I can flyTurkey");
        }
    }
    public class CantFlyTurkey : IFlyTurkey
    {
        public void FlyTurkey()
        {
            Console.WriteLine("I cant flyTurkey");
        }
    }
}

