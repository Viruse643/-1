using System;
using Ducks.Interfaces;
using IteratorPattern.MasivOrList;
using IteratorPattern.Iterator;

namespace IteratorPattern.Menu
{
    class Menuu
    {
        DuckArr _arrDuck;
        DuckList _listDuck;

        public Menuu(DuckArr arrDuck, DuckList listDuck)
        {
            _arrDuck = arrDuck;
            _listDuck = listDuck;
        }

        public void ListDucks()
        {
            IIterator arrIterator = _arrDuck.CreateIterator();
            IIterator listIterator = _listDuck.CreateIterator();

            Console.WriteLine("ArrayDucks:");
            ReadDuckMenu(arrIterator);
            Console.WriteLine("ListDucks:");
            ReadDuckMenu(listIterator);
        }

        public void ReadDuckMenu(IIterator iterator)
        {
            int item = 1;
            while (iterator.HasNext())
            {
                Console.WriteLine("Элемент меню: " + item);
                IBaseDuck duck = iterator.Next();

                duck.Fly();
                duck.Quack();
                duck.Walk();

                Console.WriteLine();
                item++;
            }
        }
    }
}

