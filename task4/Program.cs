using System;

class Program
{
    public static string ReadTextFromConsole()
    {
        string? text = String.Empty;
        Console.WriteLine("Введите текст:");
        text = Console.ReadLine();
        return text;
    }

    public static string ReadTextFromFile(string path)
    {
        string text = String.Empty;
        using(StreamReader reader = new StreamReader(path))
        {
            text = reader.ReadToEnd();
        }
        return text;
    }

    public static int Input()
    {
        int selection;
        Console.WriteLine("[1] Считать текст из консоли\n" +
                          "[2] Считать текст из файла");

        while (!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.Clear();
            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[1] Считать текст из консоли\n" +
                              "[2] Считать текст из файла");
        }
        return selection;
    }

    public static string ReadText()
    {
        string text = String.Empty;

        flag1:
        int selection = Input();

        switch (selection)
        {
            case 1:
                text = ReadTextFromConsole();
                return text;

            case 2:
                text = ReadTextFromFile("text.txt");
                return text;

            default:
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                goto flag1;
        }
    }
    static void Main()
    {
        string text = ReadText();
    }
}