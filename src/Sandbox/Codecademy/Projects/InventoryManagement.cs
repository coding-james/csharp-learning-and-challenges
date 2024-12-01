using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codecademy.Projects
{
    public class InventoryManagement
    {
        public static void System(string[] args)
        {
            // Your code goes here
            List<string> inventoryList = new List<string>();

            // Add items to list
            inventoryList.Add("Printer");
            inventoryList.Add("Laptop");
            inventoryList.Add("Desk Chair");
            inventoryList.Add("Monitor");
            inventoryList.Add("Keyboard");

            Console.WriteLine($"Number of items in inventory: {inventoryList.Count}{Environment.NewLine}");

            // Check if Desk Chair exists and write outcome
            bool hasDeskChair = inventoryList.Contains("Desk Chair");
            Console.WriteLine($"List contains Desk Chair: {hasDeskChair}{Environment.NewLine}");

            // Remove Printer and store outcome of removal in removed
            bool removed = inventoryList.Remove("Printer");
            Console.WriteLine($"Removed Printer: {removed}{Environment.NewLine}");

            // Write a list of items
            Console.WriteLine("Items currently in inventoryList:");
            foreach (var item in inventoryList)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine(Environment.NewLine);

            // Create a new list of new items, add into inventoryList
            List<string> newItems = new List<string>() { "Mouse", "Desk Lamp"};
            inventoryList.AddRange(newItems);

            // Remove these two items
            inventoryList.RemoveRange(4, 2);
            Console.WriteLine("Items currently in inventoryList:");
            foreach (var item in inventoryList)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine(Environment.NewLine);

            // Create a new list of just the first three items
            List<string> topInventory = inventoryList.GetRange(0, 3);
            Console.WriteLine("Items currently in topInventory:");
            foreach (var item in inventoryList)
            {
                Console.WriteLine($" - {item}");
            }
        }
    }
}
