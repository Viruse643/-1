using System;
using System.Collections.Generic;
using System.Text;
using Ducks.Base_Class;
using Ducks.Interfaces;

namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        IBaseDuck Next();
    }
    public class NewIteratorArray : IIterator
    {
        readonly IBaseDuck[] _bDuck;
        int _index = 0;

        public NewIteratorArray(IBaseDuck[] bDuck)
        {
            _bDuck = bDuck;
        }
        public IBaseDuck Next()
        {
            IBaseDuck duck = _bDuck[_index];
            _index++;
            return duck;
        }

        public bool HasNext()
        {
            if (_index >= _bDuck.Length || _bDuck[_index] == null)
                return false;
            else
                return true;
        }
    }
    public class NewIteratorList : IIterator
    {
        List<IBaseDuck> _bDuck;
        int _index = 0;

        public NewIteratorList(List<IBaseDuck> bDuck)
        {
            _bDuck = bDuck;
        }
        
        public IBaseDuck Next()
        {
            IBaseDuck duck = _bDuck[_index];
            return duck;
        }

        public bool HasNext()
        {
            if (_index >= _bDuck.Count || _bDuck[_index] == null)
                return false;
            else
                return true;
        }
    }
}