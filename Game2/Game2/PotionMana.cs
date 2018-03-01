using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class PotionMana : Potion
    {
        private static int _price = 35; //static price
        private static int _recovery = 105; //how many mana point can be recovered

        public PotionMana() :
            base("Potion", "Mana", _price, _recovery)
        {

        }

        public override void getFullInfo()
        {
            Console.WriteLine("----------------- Mana -----------------");
            Console.WriteLine("         Type: " + this.type);
            Console.WriteLine("   Under Type: " + this.underType);
            Console.WriteLine("        Price: " + this.price);
            Console.WriteLine("     Recovery: " + getRecovery());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        public override int getRecovery()
        {
            return _recovery;
        }
    }
}
