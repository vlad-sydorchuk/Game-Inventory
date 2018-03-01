using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    abstract class Armor : Item
    {
        protected int resistance; // resistance to damage (hit = damage - resistance)
        protected double weight; // weight of armor
        protected string category; //low, middle or hard

        protected Armor(string type, string underType, int price,
            int resistance, double weight, string category) : 
            base(type, underType, price)
        {
            this.resistance = resistance;
            this.weight = weight;
            this.category = category;
        }
    }
}
