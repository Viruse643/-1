using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;

namespace Adapter
{
    public class AdapterPatt : IBaseDuck
    {
        IBaseTurkey _baseTurkey;

        public AdapterPatt(IBaseTurkey baseTurkey)
        {
            _baseTurkey = baseTurkey;
        }

        public void Fly()
        {
            _baseTurkey.FlyTurkey();
        }

        public void Quack()
        {
            _baseTurkey.CackleTurkey();
        }

        public void Walk()
        {
            _baseTurkey.FlyTurkey();
        }
    }
}