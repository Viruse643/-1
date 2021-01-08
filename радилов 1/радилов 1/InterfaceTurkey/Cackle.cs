using System;
using System.Collections.Generic;
using System.Text;

namespace радилов_1.InterfaceTurkey
{
    public interface ICackle
    {
        void Cackle();
    }

    public class CanCackle : ICackle
    {
        public void Cackle()
        {
            Console.WriteLine("I can Cackle!");
        }
    }

    public class CantCackle : ICackle
    {
        public void Cackle()
        {
            Console.WriteLine("I can't Cackle!");
        }
    }

}
