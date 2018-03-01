using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class PotionHealth : Potion
    {
        private static int _price = 50; //static price
        private static int _recovery = 75; // how many health point can be recovered

        public PotionHealth() :
            base("Potion", "Health", _price, _recovery)
        {

        }

        public override void getFullInfo()
        {
            Console.WriteLine("---------------- Health ----------------");
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
