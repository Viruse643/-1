using System;
using System.Collections.Generic;
using System.Text;
using радилов_1.InterfaceDuck;

namespace радилов_1.BaseClasses
{
    public interface IBaseDuck
    {
        void Fly();
        void Quack();
        void Swim();
    }

    public class BaseDuck : IBaseDuck
    {
        readonly IFly _fly;
        readonly IQuack _quack;
        readonly ISwim _swim;
        public BaseDuck(IFly fly, IQuack quack, ISwim swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }

        public void Fly()
        {
            _fly.Fly();
        }

        public void Quack()
        {
            _quack.Quack();
        }
        public void Swim() 
        {
            _swim.Swim();
        }
    }
}
