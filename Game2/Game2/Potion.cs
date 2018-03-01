using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    abstract class Potion : Item
    {
        protected Potion(string type, string underType, int price, int recovery) :
            base(type, underType, price)
        {

        }

        public abstract int getRecovery();
    }
}
