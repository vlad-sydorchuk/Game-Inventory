using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class WeaponBow : Weapon
    {
        private double _rangeOfFire; //range of fire

        public WeaponBow(int price, int damage, string material, double range) :
            base("Weapon", "Bow", price, damage, material)
        {
            this._rangeOfFire = range;
        }

        public override void getFullInfo()
        {
            Console.WriteLine("----------------- Bow ------------------");
            Console.WriteLine("         Type: " + this.type);
            Console.WriteLine("   Under Type: " + this.underType);
            Console.WriteLine("        Price: " + this.price);
            Console.WriteLine("       Damage: " + this.damage);
            Console.WriteLine("     Material: " + this.material);
            Console.WriteLine("Range of Fire: " + this._rangeOfFire);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}
