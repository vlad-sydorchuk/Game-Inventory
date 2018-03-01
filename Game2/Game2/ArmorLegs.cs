using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class ArmorLegs : Armor
    {
        private double _height; //height of boots
        private int _size; // leg size

        public ArmorLegs(int price, int resistance, double weight, string category,
            double height, int size) : 
            base("Armor", "Legs", price, resistance, weight, category)
        {
            this._height = height;
            this._size = size;
        }

        public override void getFullInfo()
        {
            Console.WriteLine("----------------- Legs -----------------");
            Console.WriteLine("         Type: " + this.type);
            Console.WriteLine("   Under Type: " + this.underType);
            Console.WriteLine("        Price: " + this.price);
            Console.WriteLine("   Resistance: " + this.resistance);
            Console.WriteLine("       Weight: " + this.weight);
            Console.WriteLine("     Category: " + this.category);
            Console.WriteLine("       Height: " + this._height);
            Console.WriteLine("         Size: " + this._size);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}
