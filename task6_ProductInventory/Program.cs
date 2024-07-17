using System.Threading.Channels;
using task6_ProductInventory;

class Program
{
    public static void Main()
    {
        Product prod1 = new Product(5m);
        Product prod2 = new Product("Молоко", 6m, 3);
        Product prod3 = new Product("Банан", 2);
        Product prod4 = new Product("Сыр", 3m);
        Product prod5 = new Product();
        Product prod6 = new Product(1, 3);
        Product prod7 = new Product("Апельсин", 7m, 10);
        Product prod8 = new Product("Яблоко", 3m, 6);

        Inventory inv = new Inventory();

        Inventory.AddItem(inv, prod1);
        Inventory.AddItem(inv, prod2);
        Inventory.AddItem(inv, prod3);
        Inventory.AddItem(inv, prod4);
        Inventory.AddItem(inv, prod5);
        Inventory.AddItem(inv, prod6);
        Inventory.AddItem(inv, prod7);
        Inventory.AddItem(inv, prod8);

        Inventory.ShowInventoryInfo(inv);
        Console.WriteLine("\n\n");

        Inventory.RemoveItem(inv, prod5);
        Inventory.RemoveItem(inv, prod1);
        Inventory.RemoveItem(inv, prod8);

        Inventory.ShowInventoryInfo(inv);
        Console.ReadKey();
    }
}