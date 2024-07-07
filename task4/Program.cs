using System;
using System.Text;

class Program
{
    public static string ReadTextFromConsole()
    {
        string? text = String.Empty;
        Console.Clear();
        Console.WriteLine("Введите текст:");
        text = Console.ReadLine();
        Console.Clear();
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

    public static void ShowMenu()
    {
        Console.WriteLine("[1] Показать текст\n" +
                          "[2] Найти слова, содержащие максимальное количество цифр\n" +
                          "[3] Найти самое длинное слово и определить, сколько раз оно встретилось в тексте\n" +
                          "[4] Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»\n" +
                          "[5] Вывести на экран сначала вопросительные, а затем восклицательные предложения\n" +
                          "[6] Вывести на экран только предложения, не содержащие запятых\n" +
                          "[7] Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву\n" +
                          "[8] Выход");
    }

    public static void FindTheLongestWordAndFrequency(string[] words)
    {
        string keyWord = words[0];
        int wordLength = words[0].Length;
        int frequency = 0;

        foreach(string word in words)
        {
            if(word.Length > wordLength)
            {
                keyWord = word;
                wordLength = word.Length;
            }
        }

        foreach(string word in words)
        {
            if(word ==  keyWord)
                frequency++;
        }
        Console.WriteLine($"Слово: {keyWord}\nЧастота: {frequency}");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ReplaceNums(ref string text)
    {
        var txt = new StringBuilder(text);

        txt.Replace("0", "ноль");
        txt.Replace("1", "один");
        txt.Replace("2", "два");
        txt.Replace("3", "три");
        txt.Replace("4", "четыре");
        txt.Replace("5", "пять");
        txt.Replace("6", "шесть");
        txt.Replace("7", "семь");
        txt.Replace("8", "восемь");
        txt.Replace("9", "девять");

        text = txt.ToString();
    }
    static void Main()
    {
        string text = ReadText();
        string[] words = text.Split(' ');
        string[] sentences = text.Split('?','!','.');
        int selection;

        while (true)
        {
            flag2:
            ShowMenu();
            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                ShowMenu();
            }

            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(text);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    
                    break;

                case 3:
                    Console.Clear();
                    FindTheLongestWordAndFrequency(words);
                    break;

                case 4:
                    Console.Clear();
                    ReplaceNums(ref text);
                    break;

                case 5:
                    
                    break;

                case 6:
                    
                    break;

                case 7:
                    
                    break;

                    case 8:
                        Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    goto flag2;
            }
        }
    }
}