using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class WeaponSword : Weapon
    {
        private double _lengthSword; // sword length
        private double _thicknessBlade; // blade thickness

        public WeaponSword(int price, int damage, string material, double len, double thickness) : 
            base("Weapon", "Sword", price, damage, material)
        {
            this._lengthSword = len;
            this._thicknessBlade = thickness;
        }

        public override void getFullInfo()
        {
            Console.WriteLine("----------------- Sword ----------------");
            Console.WriteLine("           Type: " + this.type);
            Console.WriteLine("     Under Type: " + this.underType);
            Console.WriteLine("          Price: " + this.price);
            Console.WriteLine("         Damage: " + this.damage);
            Console.WriteLine("       Material: " + this.material);
            Console.WriteLine("   Length Sword: " + this._lengthSword);
            Console.WriteLine("Thickness Blade: " + this._thicknessBlade);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

    }
}
