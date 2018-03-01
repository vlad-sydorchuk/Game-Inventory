using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    abstract class Weapon : Item
    {
        protected int damage; // damage
        protected string material; // tree, metal and other

        protected Weapon (string type, string underType, int price, int damage, string material) : 
            base(type, underType, price)
        {
            this.damage = damage;
            this.material = material;
        }
    }
}
