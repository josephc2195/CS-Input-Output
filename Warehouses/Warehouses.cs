using System;
namespace Warehouses
{
    public class Warehouses
    {
        public string Name;
        public int i_102;
        public int i_215;
        public int i_410;
        public int i_525;
        public int i_711;

        public Warehouses(string name, int i_102, int i_215, int i_410, int i_525, int i_711)
        {
            this.Name = name;
            this.i_102 = i_102;
            this.i_215 = i_215;
            this.i_410 = i_410;
            this.i_525 = i_525;
            this.i_711 = i_711;
        }

        public void purchase(int amount, string item)
        {
            Console.WriteLine("New Purchase!");
            Console.WriteLine($"{Name} has purchased {amount} of item number {item}");
            if(item == "102")
            {
                i_102 += amount;
                Console.WriteLine($"{Name} now has {i_102} of item number 102.");
            }

            else if (item == "215")
            {
                i_215 += amount;
                Console.WriteLine($"{Name} now has {i_215} of item number 215");
            }

            else if (item == "410")
            {
                i_410 += amount;
                Console.WriteLine($"{Name} now has {i_410} of item number 410");
            }

            else if (item == "525")
            {
                i_525 += amount;
                Console.WriteLine($"{Name} now has {i_525} of item number 525");
            }

            else if (item == "711")
            {
                i_711 += amount;
                Console.WriteLine($"{Name} now has {i_711} of item number 711");
            }
        }

        public void sale()
        {
            Console.WriteLine("New Sale!");

        }

        public void displayStartingInv()
        {
            Console.WriteLine($"Starting Inventory for {Name}: {i_102}, {i_215}, {i_410}, {i_525}, {i_711}.");
        }
    }
}
