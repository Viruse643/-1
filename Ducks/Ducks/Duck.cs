using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Ducks.Ducks
{
    public class Duck : Base_Class.BaseDuck
    {
        public Duck(IFly _fly, IQuack _quack, IWalk _walk) : base(_fly, _quack, _walk) { }
    }
}
