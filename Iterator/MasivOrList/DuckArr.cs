using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Interfaces;
using IteratorPattern.Iterator;



namespace IteratorPattern.MasivOrList
{
    class DuckArr
    {
        readonly IBaseDuck[] _bDuck;

        public DuckArr() 
        {
            CreateArrAndList CreateArray = new CreateArrAndList();
            _bDuck = CreateArray.CreateArray();
        }
        public IIterator CreateIterator() 
        {
            return new NewIteratorArray(_bDuck);
        }
    }
}
