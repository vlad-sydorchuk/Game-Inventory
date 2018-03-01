using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Inventory
    {
        private int _sizeInventory; //how many items can be added to this inventory
        private int _countItems; //how many items was added
        private int _countPotionOfHealth; //how many potion of health was added (because we must save this info in one line)
        private int _countPotionOfMana; // look above ^

        private ArrayList _items = new ArrayList();

        public Inventory (int size)
        {
            _sizeInventory = size;
        }

        public void addNewWeapon()
        {
            if (checkCountItems())
            {
                string typeWeapon = null;
                bool run = true;

                while (run)
                {
                    Console.Clear();
                    Console.WriteLine("------- Available weapon's -------");
                    Console.WriteLine("|  --> Sword                     |");
                    Console.WriteLine("|  --> Bow                       |");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Input weapon type: ");
                    typeWeapon = Console.ReadLine();
                    if (typeWeapon == Item.Sword || typeWeapon == Item.Bow)
                        run = false;
                }

                int price, damage;
                string material;
                double len, thickness, range;

                Console.Clear();
                Console.WriteLine("---------- Add Weapon ----------");
                Console.Write("Enter price: ");
                int.TryParse(Console.ReadLine(), out price);
                Console.Write("Enter damage: ");
                int.TryParse(Console.ReadLine(), out damage);
                Console.Write("Enter material: ");
                material = Console.ReadLine();

                if (typeWeapon == Item.Sword)
                {
                    Console.Write("Enter sword length: ");
                    double.TryParse(Console.ReadLine(), out len);
                    Console.Write("Enter sword thickness: ");
                    double.TryParse(Console.ReadLine(), out thickness);

                    _items.Add(new WeaponSword(price, damage, material, len, thickness));
                }
                else if (typeWeapon == Item.Bow)
                {
                    Console.Write("Enter bow range: ");
                    double.TryParse(Console.ReadLine(), out range);

                    _items.Add(new WeaponBow(price, damage, material, range));
                }
                _countItems++;
            }
        }

        // can be added to inventory?
        private bool checkCountItems()
        {
            if (_countItems >= _sizeInventory)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inventory is full");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return false;
            }
            return true;
        }

        public void addNewArmor()
        {
            if (checkCountItems())
            {
                string typeArmor = null;
                bool run = true;

                while (run)
                {
                    Console.Clear();
                    Console.WriteLine("------- Available armor's --------");
                    Console.WriteLine("|  --> Body                      |");
                    Console.WriteLine("|  --> Legs                      |");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Input armor type: ");
                    typeArmor = Console.ReadLine();
                    if (typeArmor == Item.Body || typeArmor == Item.Legs)
                        run = false;
                }

                int price, resistance, size;
                string category, material;
                double weight, height;

                Console.Clear();
                Console.WriteLine("---------- Add Armor -----------");
                Console.Write("Enter price: ");
                int.TryParse(Console.ReadLine(), out price);
                Console.Write("Enter resistance: ");
                int.TryParse(Console.ReadLine(), out resistance);
                Console.Write("Enter category (low, middle): "); //but you can write everything
                category = Console.ReadLine();
                Console.Write("Enter armor weight: ");
                double.TryParse(Console.ReadLine(), out weight);

                if (typeArmor == Item.Body)
                {
                    Console.Write("Enter material: ");
                    material = Console.ReadLine();

                    _items.Add(new ArmorBody(price, resistance, weight, category, material));
                }
                else if (typeArmor == Item.Legs)
                {
                    Console.Write("Enter armor height: ");
                    double.TryParse(Console.ReadLine(), out height);
                    Console.Write("Enter size: ");
                    int.TryParse(Console.ReadLine(), out size);

                    _items.Add(new ArmorLegs(price, resistance, weight, category, height, size));
                }
                _countItems++;
            }
        }

        public void addNewPotion()
        {
            if (checkCountItems())
            {
                string typePotion = null;
                bool run = true;

                while (run)
                {
                    Console.Clear();
                    Console.WriteLine("------ Available potion's -------");
                    Console.WriteLine("|  --> Health                    |");
                    Console.WriteLine("|  --> Mana                      |");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Input potion type: ");
                    typePotion = Console.ReadLine();
                    if (typePotion == "Health" || typePotion == "Mana")
                        run = false;
                }

                if (typePotion == Item.Health)
                {
                    if (_countPotionOfHealth == 0)
                        _items.Add(new PotionHealth());
                    _countPotionOfHealth++;
                }
                else if (typePotion == Item.Mana)
                {
                    if (_countPotionOfMana == 0)
                        _items.Add(new PotionMana());
                    _countPotionOfMana++;
                }
                _countItems++;
            }
        }

        public Item getItem(int index)
        {
            return (Item)_items[index]; 
        }

        public void deleteItem()
        {
            int index;
            int countLines = Count(); // countLines -  how many lines will be in inventory

            if (getCountHealth() > 1)
                countLines = countLines - getCountHealth() + 1;
            if (getCountMana() > 1)
                countLines = countLines - getCountMana() + 1;

            Console.Write("Input index: ");
            int.TryParse(Console.ReadLine(), out index);
            if (index >= 0 && index < countLines)
            {
                if (_items[index] is PotionHealth)
                {
                    _countPotionOfHealth--;
                    if (_countPotionOfHealth == 0)
                        _items.RemoveAt(index);
                }
                else if (_items[index] is PotionMana)
                {
                    _countPotionOfMana--;
                    if (_countPotionOfMana == 0)
                        _items.RemoveAt(index);
                }
                else
                    _items.RemoveAt(index);
                _countItems--;
            }
        }

        public void getInfo()
        {
            int index;
            int countLines = Count(); // countLines -  how many lines will be in inventory

            if (getCountHealth() > 1)
                countLines = countLines - getCountHealth() + 1;
            if (getCountMana() > 1)
                countLines = countLines - getCountMana() + 1;

            Console.Write("Input index: ");
            int.TryParse(Console.ReadLine(), out index);
            if (index >= 0 && index < countLines)
                ((Item)_items[index]).getFullInfo();
        }

        public int Count()
        {
            return _countItems;
        }

        public int getCountHealth()
        {
            return _countPotionOfHealth;
        }

        public int getCountMana()
        {
            return _countPotionOfMana;
        }
    }
}
