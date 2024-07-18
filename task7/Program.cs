using task7;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите имя собаки:");
        string name = Console.ReadLine();

        Animal Dog = new Dog();
        Dog.SetName(name);
        Dog.Eat();
        Console.ReadKey();
    }
}