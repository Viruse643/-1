using System;
using System.Collections.Generic;
using System.Text;
using Ducks;

namespace Ducks.Classes
{
    public class CanQuack : Interfaces.IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I Can Quick");
        }
    }
    public class CantQuack : Interfaces.IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I Can Quick");
        }
    }
}
