using System;
using Ducks.Base_Class;
using Ducks.Ducks;
using Ducks.Classes;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck(new CanFly(), new CanQuack(), new CanWalk());
            duck.GetInfo();


            Turkey turkey = new Turkey(new CanFlyTurkey(), new CanCackleTurkey(), new CanswimTurkey());
            turkey.GetInfoTurkey();

        }
    }
}
