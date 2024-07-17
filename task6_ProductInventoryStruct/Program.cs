using System.Threading.Channels;
using task6_ProductInventoryStruct;

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

        Inventory.AddItem(ref inv, prod1);
        Inventory.AddItem(ref inv, prod2);
        Inventory.AddItem(ref inv, prod3);
        Inventory.AddItem(ref inv, prod4);
        Inventory.AddItem(ref inv, prod5);
        Inventory.AddItem(ref inv, prod6);
        Inventory.AddItem(ref inv, prod7);
        Inventory.AddItem(ref inv, prod8);

        Inventory.ShowInventoryInfo(inv);
        Console.WriteLine("\n\n");

        Inventory.RemoveItem(ref inv, prod5);
        Inventory.RemoveItem(ref inv, prod1);
        Inventory.RemoveItem(ref inv, prod8);

        Inventory.ShowInventoryInfo(inv);
        Console.ReadKey();
    }
}