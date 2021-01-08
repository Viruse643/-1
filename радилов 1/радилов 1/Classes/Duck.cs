using System;
using System.Collections.Generic;
using System.Text;
using радилов_1.InterfaceDuck;
using радилов_1.BaseClasses;

namespace радилов_1.Classes
{
    public class Duck : BaseDuck
    {
        public Duck(IFly fly, IQuack quack, ISwim swim) : base (fly, quack, swim) { }
    }
}
