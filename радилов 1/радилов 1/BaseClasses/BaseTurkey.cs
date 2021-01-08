using System;
using System.Collections.Generic;
using System.Text;
using радилов_1.InterfaceTurkey;

namespace радилов_1.BaseClasses
{
       public interface IBaseTurkey
        {
            void Cackle();
            void Eat();
            void Sleep();
        }

        public class BaseTurkey : IBaseTurkey
        {
            readonly ICackle _cackle;
            readonly IEat _eat;
            readonly ISleep _sleep;
            public BaseTurkey(ICackle cackle, IEat eat, ISleep sleep)
            {
                _cackle = cackle;
                _eat = eat;
                _sleep = sleep;
            }

            public void Cackle()
            {
                _cackle.Cackle();
            }

            public void Eat()
            {
                _eat.Eat();
            }
            public void Sleep()
            {
                _sleep.Sleep();
            }
        }
    }