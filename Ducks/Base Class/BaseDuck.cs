using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Ducks.Base_Class
{
    public abstract class BaseDuck : IBaseDuck
    {
        readonly IFly _fly;
        readonly IQuack _quack;
        readonly IWalk _walk;
        protected BaseDuck(IFly fly, IQuack quack, IWalk walk)
        {
            _fly = fly;
            _quack = quack;
            _walk = walk;
        }
        public void Fly()
        {
            _fly.Fly();
        }
        public void Quack()
        {
            _quack.Quack();
        }
        public void Walk()
        {
            _walk.Walk();
        }

        public void GetInfo()
        {
            Console.WriteLine("Утка:");
            _fly.Fly();
            _quack.Quack();
            _walk.Walk();
        }
    }
}
