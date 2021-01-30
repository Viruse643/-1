using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Ducks.Base_Class
{
   public abstract class BaseTurkey : IBaseTurkey
    {
        readonly IFlyTurkey _flyTurkey;
        readonly ICackleTurkey _cackleTurkey;
        readonly ISwimTurkey _swimTurkey;
        protected BaseTurkey(IFlyTurkey flyTurkey, ICackleTurkey cackleTurkey, ISwimTurkey swimTurkey)
        {
            _flyTurkey = flyTurkey;
            _cackleTurkey = cackleTurkey;
            _swimTurkey = swimTurkey;
        }
        public void FlyTurkey()
        {
            _flyTurkey.FlyTurkey();
        }
        public void CackleTurkey()
        {
            _cackleTurkey.CackleTurkey();
        }
        public void SwimTurkey()
        {
            _swimTurkey.SwimTurkey();
        }
        public void GetInfoTurkey()
        {
            Console.WriteLine("Индюшка:");
            _flyTurkey.FlyTurkey();
            _cackleTurkey.CackleTurkey();
            _swimTurkey.SwimTurkey();
        }
    }
}
