using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    abstract class Item
    {
        public static readonly string Sword = "Sword";
        public static readonly string Bow = "Bow";
        public static readonly string Body = "Body";
        public static readonly string Legs = "Legs";
        public static readonly string Health = "Health";
        public static readonly string Mana = "Mana";

        protected string type { get;  } //Potion, Weapon or Armor
        protected string underType { get; } //Potion of Health, Potion of Mana, Sword, (Armor)Body and etc
        protected int price { get; } //how much this item

        abstract public void getFullInfo();

        protected Item(string type, string underType, int price)
        {
            this.type = type;
            this.underType = underType;
            this.price = price;
        }

        public void showInfo()
        {
            Console.WriteLine("|{0}|{1}|{2}|",
                createString(type),
                createString(underType),
                createString(price.ToString()));
        }

        public void showInfo(int count) // for Potion of Health and Potion of Mana
        {
            Console.WriteLine("|{0}|{1}|{2}|",
                createString(type),
                createString(underType + "(" + count + ")"), //return --> Health(count)
                createString((price * count).ToString()));
        }

        private string createString(string str)
        {
            bool run = true; // for while
            string ans = null; 
            int len = str.Length;

            if (len > 9)
                ans = str.Substring(0, 7); // if "Weapon123456": len > 9; create "Weapon1": len = 7 
            else
                ans = str.Substring(0, len); // if "Weapon": len = 6; create "Weapon": len = 6 

            while (run)
            {
                if (ans.Length >= 9)
                    run = false;
                if (len > 9) // if str was like a "Weapon123456" => "Weapon1" => "Weapon1..": len = 9;
                    ans += ".";
                else
                    ans = ans.Insert(0, " "); // if str was like a "Weapon" => "Weapon" => "    Weapon1": len = 9;
            }
            return ans;
        }
    }
}
