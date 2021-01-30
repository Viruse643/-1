using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;
using IteratorPattern.Iterator;



namespace IteratorPattern.MasivOrList
{
    class DuckList
    {
        readonly List<IBaseDuck> _bDuck;

        public DuckList()
        {
            CreateArrAndList CreateList = new CreateArrAndList();
            _bDuck = CreateList.CreateList();
        }
        public IIterator CreateIterator()
        {
            return new NewIteratorList(_bDuck);
        }
    }
}
