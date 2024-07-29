using System;
using task8;

class Program
{
    public static void task1()
    {
        Debt mortgage = new Debt(120000.0, 1.01);
        mortgage.PrintBalance();
        mortgage.WaitOneYear();
        mortgage.PrintBalance();

        // Wait 20 years
        int years = 0;
        while (years < 20)
        {
            mortgage.WaitOneYear();
            years = years + 1;
        }
        mortgage.PrintBalance();
    }

    public static void task2()
    {
        Person human = new Person();
        human.Greet();

        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher();
        teacher.SetAge(35);
        teacher.Greet();
        teacher.Explain();
    }

    public static void task3()
    {
        SportsCar car = new SportsCar(0, 13);
        Console.WriteLine("Какое расстояние нужно проехать?(км):");
        int.TryParse(Console.ReadLine(), out int distance);
        car.Drive(distance);
    }

    public static void Main(string[] args)
    {
        int selection;

        flag1:
        Console.WriteLine("[1] Первое задание\n" +
                          "[2] Второе задание\n" +
                          "[3] Третье задание");
        while (!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.Clear();
            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[1] Задание 1\n" +
                              "[2] Задание 2\n" +
                              "[3] Задание 3");
        }
        Console.Clear();

        switch (selection)
        {
            case 1:
                task1();
                break;
            case 2:
                task2();
                break;
            case 3:
                task3();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                goto flag1;
        }
    }
}
