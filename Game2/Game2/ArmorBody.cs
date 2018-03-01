using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class ArmorBody : Armor
    {
        private string _material; // metal, tree :D, or other

        public ArmorBody(int price, int resistance, double weight, string category, string material) : 
            base("Armor", "Body", price, resistance, weight, category)
        {
            this._material = material;
        }

        public override void getFullInfo()
        {
            Console.WriteLine("----------------- Body -----------------");
            Console.WriteLine("         Type: " + this.type);
            Console.WriteLine("   Under Type: " + this.underType);
            Console.WriteLine("        Price: " + this.price);
            Console.WriteLine("   Resistance: " + this.resistance);
            Console.WriteLine("       Weight: " + this.weight);
            Console.WriteLine("     Category: " + this.category);
            Console.WriteLine("     Material: " + this._material);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}
