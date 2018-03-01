using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool work = true;
            string command = null;
            int sizeInventory;
            Inventory inventory = null;

            try
            {
                Console.Write("Input size of inventory: ");
                int.TryParse(Console.ReadLine(), out sizeInventory);
                if (sizeInventory < 1)
                {
                    Console.WriteLine("You must input integer > 0");
                    work = false;
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
                inventory = new Inventory(sizeInventory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem with create new inventory... try later.\nOriginal exception: " + ex);
            }

            while (work)
            {
                Console.Clear();
                showCommand(); //show available command
                Console.WriteLine();
                showInventory(inventory); //show your inventory
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Input command: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                command = Console.ReadLine();

                switch (command)
                {
                    case "exit":
                        work = false;
                        break;
                    case "add weapon":
                        inventory.addNewWeapon();
                        break;
                    case "add armor":
                        inventory.addNewArmor();
                        break;
                    case "add potion":
                        inventory.addNewPotion();
                        break;
                    case "get info":
                        Console.Clear();
                        showInventory(inventory);
                        inventory.getInfo();
                        break;
                    case "delete item":
                        Console.Clear();
                        showInventory(inventory);
                        inventory.deleteItem();
                        break;
                    default:
                        Console.WriteLine("Command not found.");
                        break;
                }
                
            }
        }

        public static void showCommand()
        {
            Console.WriteLine("--------------- Command's --------------");
            Console.WriteLine("| --> add weapon                       |");
            Console.WriteLine("| --> add armor                        |");
            Console.WriteLine("| --> add potion                       |");
            Console.WriteLine("| --> get info                         |");
            Console.WriteLine("| --> delete item                      |");
            Console.WriteLine("| --> exit                             |");
            Console.WriteLine("----------------------------------------");
        }

        public static void showInventory(Inventory items)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|                INVENTORY             |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|Index|   Type   |Under Type|  Price   |");
            Console.WriteLine("----------------------------------------");

            int end = items.Count();
            if (items.getCountHealth() > 1)
                end = end - items.getCountHealth() + 1;
            if (items.getCountMana() > 1)
                end = end - items.getCountMana() + 1;

            for (int i = 0; i < end; i++)
            {
                                                // |Index|
                if (i < 9)                      // |    1|
                    Console.Write("|    {0}", i);
                else if (i > 9 && i < 99)       // |   11|
                    Console.Write("|   {0}", i);
                else if (i > 99 && i < 999)     // |  111|
                    Console.Write("|  {0}", i);
                else if (i > 999 && i < 9999)   // | 1111|
                    Console.Write("| {0}", i);
                else                            // |11111|
                    Console.Write("|{0}", i);

                string type = items.getItem(i).GetType().ToString();
                if (type.Contains("Health") || type.Contains("Mana"))
                {
                    if(type.Contains("Health"))
                        items.getItem(i).showInfo(items.getCountHealth());
                    else if (type.Contains("Mana"))
                        items.getItem(i).showInfo(items.getCountMana());
                }
                else
                    items.getItem(i).showInfo();
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
