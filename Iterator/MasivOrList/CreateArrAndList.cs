using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Base_Class;
using Ducks.Interfaces;
using Ducks.Classes;
using Ducks.Ducks;
using Adapter;

namespace IteratorPattern.MasivOrList
{
    public class CreateArrAndList
    {
        public IBaseDuck[] CreateArray()
        {
            IBaseDuck[] _bDuck = new IBaseDuck[3];
            _bDuck[0] = new Duck(new CanFly(), new CanQuack(), new CantWalk());
            _bDuck[1] = new Duck(new CanFly(), new CanQuack(), new CantWalk());
            _bDuck[2] = new Duck(new CanFly(), new CanQuack(), new CantWalk());

            return _bDuck;  
        }

        public List<IBaseDuck> CreateList() 
        {
            List<IBaseDuck> _bDock = new List<IBaseDuck>();
            _bDock.Add(new AdapterPatt(new Turkey(new CanFlyTurkey(),new CantCackleTurkey(), new CantSwimTurkey())));
            _bDock.Add(new AdapterPatt(new Turkey(new CanFlyTurkey(), new CantCackleTurkey(), new CantSwimTurkey())));
            _bDock.Add(new AdapterPatt(new Turkey(new CanFlyTurkey(), new CantCackleTurkey(), new CantSwimTurkey())));

            return _bDock;
        }
    }

}
