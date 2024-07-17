using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task6_ProductInventoryStruct
{
    public struct Inventory
    {
        List<Product> Items;
        decimal FullPrice;
        int FullQuantity;

        public Inventory()
        {
            Items = new List<Product>();
            FullPrice = 0;
            FullQuantity = 0;
        }

        public static void AddItem(ref Inventory inventory, Product Item)
        {
            inventory.Items.Add(Item);
            if (Item.Price != 0)
            {
                inventory.FullQuantity += Item.Quantity;
                inventory.FullPrice += Item.Price * Item.Quantity;
            }
        }

        public static void RemoveItem(ref Inventory inventory, Product Item)
        {
            inventory.Items.Remove(Item);
            if (Item.Price != 0)
            {
                inventory.FullQuantity -= Item.Quantity;
                inventory.FullPrice -= Item.Price * Item.Quantity;
            }
        }

        public static void ShowInventoryInfo(Inventory inventory)
        {
            foreach (var Item in inventory.Items)
            {
                if (Item.Quantity == 0 || Item.Price == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0,-25} | {1,-10} | {2,-10}", $"Продукт: \"{Item.ID}\"", $"Кол-во: {Item.Quantity}", $"Стоимость: {Item.Price:C2}");
                    Console.ResetColor();
                }
                else if (Item.ID == "Неизвестно")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0,-25} | {1,-10} | {2,-10}", $"Продукт: \"{Item.ID}\"", $"Кол-во: {Item.Quantity}", $"Стоимость: {Item.Price:C2}");
                    Console.ResetColor();
                }
                else
                    Console.WriteLine("{0,-25} | {1,-10} | {2,-10}", $"Продукт: \"{Item.ID}\"", $"Кол-во: {Item.Quantity}", $"Стоимость: {Item.Price:C2}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0,-25} | {1,-10} | {2,-10}", "Общее:", $"Кол-во: {inventory.FullQuantity}", $"Cтоимость: {inventory.FullPrice:C2}");
            Console.ResetColor();
        }
    }
}
