using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Ducks.Classes
{
    public class CanswimTurkey : ISwimTurkey
    {
        public void SwimTurkey()
        {
            Console.WriteLine("I can swimTurkey");
        }
    }
    public class CantSwimTurkey : ISwimTurkey
    {
        public void SwimTurkey()
        {
            Console.WriteLine("I cant SwimTurkey");
        }
    }
}

