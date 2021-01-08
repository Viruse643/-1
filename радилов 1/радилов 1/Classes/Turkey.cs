using System;
using System.Collections.Generic;
using System.Text;
using радилов_1.InterfaceTurkey;
using радилов_1.BaseClasses;

namespace радилов_1.Classes
{
    public class Turkey : BaseTurkey
    {
        public Turkey(ICackle cackle, IEat eat, ISleep sleep) : base(cackle, eat, sleep) { }
    }
}
