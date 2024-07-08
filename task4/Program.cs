using System;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

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
        Console.Clear();
        using (StreamReader reader = new StreamReader(path))
        {
            text = reader.ReadToEnd();
        }
        Console.Clear();
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

    public static void ShowInterrogativeAndExclamatorySentences(string[] sentences)
    {
        foreach(string sentence in sentences)
        {
            if(sentence.EndsWith('?'))
            {
                Console.Write($"{sentence} ");
            }
        }

        foreach (string sentence in sentences)
        {
            if (sentence.EndsWith('!'))
            {
                Console.Write($"{sentence} ");
            }
        }
        Console.ReadKey();
        Console.Clear();
    }

    public static void ShowSentencesWithoutCommas(string[] sentences)
    {
        foreach(string sentence in sentences)
        {
            if(!sentence.Contains(','))
            {
                Console.Write($"{sentence} ");
            } 
        }
        Console.ReadKey();
        Console.Clear();
    }

    public static void ShowWordsWithSameStartEnd(string[] words)
    {
        foreach(string word in words)
        {
            if (word[0] == word[word.Length - 1] && word.Length != 1 && char.IsLetter(word[0]) && char.IsLetter(word[word.Length - 1]))
            {
                Console.WriteLine(word);
            }
        }
        Console.ReadKey();
        Console.Clear();
    }

    public static void FindWordWithMaxNumberOfDigits(string[] words)
    {
        int countOfDigits = 0;
        int maxCount = 0;
        foreach(string word in words)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                    countOfDigits++;
            }
            if(countOfDigits > maxCount)
                maxCount = countOfDigits;
            countOfDigits = 0;
        }

        if (maxCount == 0)
            goto flag4;

        foreach (string word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                    countOfDigits++;
            }
            if(countOfDigits == maxCount)
                Console.WriteLine(word);
            countOfDigits = 0;
        }
        flag4:
        Console.ReadKey();
        Console.Clear();
    }

    static void Main()
    {
        string text = ReadText();
        flag3:
        string[] words = text.Split(new char[] { ',', ' ', ':', '"', '?', '!', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        string[] sentences = Regex.Split(text, @"(?<=[.!?])\s+");
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
                    Console.Clear();
                    FindWordWithMaxNumberOfDigits(words);
                    break;

                case 3:
                    Console.Clear();
                    FindTheLongestWordAndFrequency(words);
                    break;

                case 4:
                    Console.Clear();
                    ReplaceNums(ref text);
                    goto flag3;

                case 5:
                    Console.Clear();
                    ShowInterrogativeAndExclamatorySentences(sentences);
                    break;

                case 6:
                    Console.Clear();
                    ShowSentencesWithoutCommas(sentences);
                    break;

                case 7:
                    Console.Clear();
                    ShowWordsWithSameStartEnd(words);
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

//Text for testing
/*Hello! This is a sample text with several features. Can you find the words with the most numbers? For instance, consider the word "exam2023ple"! This task requires some careful consideration. In the middle of our example, let's place some numbers: 12345, 67890, and even "abc123def". What about the longest word here? Maybe it's "consideration", appearing multiple times? Or is it "supercalifragilisticexpialidocious", which shows up only once? By the way, let's replace numbers: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9. Also, sort the sentences: Is this a question? Yes, it is! No, it isn't. Wow! Look at that! Should we sort them too? Definitely! Finally, filter sentences: Here's a sentence without commas. And here's one with, just for comparison. Look for words like "radar" or "level", which start and end with the same letter. They're interesting, aren't they?*/
