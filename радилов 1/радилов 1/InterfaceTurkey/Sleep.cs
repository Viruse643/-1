using System;
using System.Collections.Generic;
using System.Text;

namespace радилов_1.InterfaceTurkey
{
    public interface ISleep
    {
        void Sleep();
    }

    public class CanSleep : ISleep
    {
        public void Sleep()
        {
            Console.WriteLine("I can Sleep!");
        }
    }

    public class CantSleep : ISleep
    {
        public void Sleep()
        {
            Console.WriteLine("I can't Sleep!");
        }
    }
}
