using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Ducks.Classes
{
    public class CanCackleTurkey : ICackleTurkey
    {
        public void CackleTurkey()
        {
            Console.WriteLine("I can cackleTurkey");
        }
    }
    public class CantCackleTurkey : ICackleTurkey
    {
        public void CackleTurkey()
        {
            Console.WriteLine("I cant cackleTurkey");
        }
    }
}
