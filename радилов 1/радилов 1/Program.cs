using System;
using радилов_1.Classes;
using радилов_1.InterfaceDuck;
using радилов_1.InterfaceTurkey;
using радилов_1.BaseClasses;

namespace радилов_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duck:");
            Duck duck = new Duck(new CanFly(), new CanQuack(), new CanSwim()); ;
            InfoDuck(duck);

            Console.WriteLine("\nRubber Duck:");
            Duck rubberDuck = new Duck(new CantFly(), new PiskQuack(), new CanSwim());
            InfoDuck(rubberDuck);
            
            Console.WriteLine("\nTurkey:");
            Turkey turkey = new Turkey(new CanCackle(), new CanEat(), new CanSleep());
            InfoTurkey(turkey);
        }

        public static void InfoDuck(BaseDuck element)
        {
            element.Fly();
            element.Quack();
            element.Swim();
        }

                public static void InfoTurkey(BaseTurkey element) 
        {
            element.Cackle();
            element.Eat();
            element.Sleep();
        }
    }
}
