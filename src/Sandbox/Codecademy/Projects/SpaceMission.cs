using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codecademy.Projects
{
    public class SpaceMission
    {
        public static void Mission(string[] args)
        {
            // Your code goes here
            string[] spaceInventory = { "Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools" };
            int[] itemQuantities = { 10, 8, 15, 5, 6, 9, 4, 7 };

            if(spaceInventory.Length == 8)
            {
                Console.WriteLine("Space Inventory is ready to go!");
            }
            else if (spaceInventory.Length > 8)
            {
                Console.WriteLine("Too many items!");
            }
            else
            {
                Console.WriteLine("Add more items!");
            }

            // Print 2 item and quantity
            Console.WriteLine($"{spaceInventory[1]}: {itemQuantities[1]}");

            // Replace last item and quantity
            spaceInventory[7] = "Scientific Instruments";
            itemQuantities[7] = 5;

            // Find the first item with quantity of 5
            int index = Array.IndexOf(itemQuantities, 5);
            Console.WriteLine($"The first item with quantity 5 is at position {index}.");

            //Reverse order of Array
            Array.Reverse(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);

            //Sort alaphabetically
            Array.Sort(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);
        }
    }
}
