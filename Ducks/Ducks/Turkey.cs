using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Ducks.Ducks
{
    public class Turkey : Base_Class.BaseTurkey
    {
        public Turkey(IFlyTurkey _flyTurkey, ICackleTurkey _cackleyTurkey, ISwimTurkey _swimTurkey) : base(_flyTurkey, _cackleyTurkey, _swimTurkey) { }
    }
}
