using System;
using System.Data;

class Program
{
    static void Main()
    {
        int rowCount, colCount;
        Console.WriteLine("Введите кол-во строк: ");
        rowCount = input("rows");

        Console.WriteLine("Введите кол-во столбцов: ");
        colCount = input("cols");

        int[,] matrix = initializeMatrix(rowCount, colCount);

        while (true)
        {
            int selection;
            showMatrix(matrix, rowCount, colCount);
            Console.WriteLine("");
            showMenu();

            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                showMatrix(matrix, rowCount, colCount);
                Console.WriteLine("");
                showMenu();
            }
            Console.Clear();

            switch (selection)
            {
                case 1:
                    (int countNegative, int countPositive) = findNegativeAndPositive(matrix, rowCount, colCount);
                    showMatrix(matrix, rowCount, colCount);
                    Console.WriteLine("");
                    Console.WriteLine($"Положительные - {countPositive}");
                    Console.WriteLine($"Отрицательные - {countNegative}");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    int choose;
                    Console.WriteLine("[1] Отсортировать по позрастанию");
                    Console.WriteLine("[2] Отсортировать по убыванию");
                    while (!int.TryParse(Console.ReadLine(), out choose))
                    {
                        Console.Clear();
                        Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("[1] Отсортировать по возрастанию");
                        Console.WriteLine("[2] Отсортировать по убыванию");
                    }
                    Console.Clear();

                    switch (choose)
                    {
                        case 1:
                            int[] row = new int[colCount];
                            for (int i = 0; i < rowCount; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                    row[j] = matrix[i, j];
                                bubbleSort(ref row);
                                insertRow(ref matrix, row, colCount, i);
                            }
                            break;

                        case 2:
                            row = new int[colCount];
                            for (int i = 0; i < rowCount; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                    row[j] = matrix[i, j];
                                bubbleSort(ref row);
                                reverseRow(ref row, colCount);
                                insertRow(ref matrix, row, colCount, i);
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    break;

                case 3:
                    int[] row1 = new int[colCount];
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; j++)
                            row1[j] = matrix[i, j];
                        reverseRow(ref row1, colCount);
                        insertRow(ref matrix, row1, colCount, i);
                    }
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
    public static int input(string selection)
    {
        int rowCount, colCount;
        switch(selection)
        {
            case "rows":
                while (!int.TryParse(Console.ReadLine(), out rowCount))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Введите кол-во строк:");
                }
                Console.Clear();
                return rowCount;

            case "cols":
                while (!int.TryParse(Console.ReadLine(), out colCount))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Введите кол-во строк:");
                }
                Console.Clear();
                return colCount;
        }
        return 0;
    }

    public static int[,] initializeMatrix(int rowCount, int colCount)
    {
        int selection;
        Console.WriteLine("[1] Инициализировать матрицу с клавиатуры");
        Console.WriteLine("[2] Инициализировать матрицу автоматически");

    flag1:
        while (!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.Clear();
            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[1] Инициализировать матрицу с клавиатуры");
            Console.WriteLine("[2] Инициализировать матрицу автоматически");
        }
        Console.Clear();

        int[,] array = new int[rowCount, colCount];

        switch (selection)
        {
            case 1:
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        Console.WriteLine($"Введите [{i}][{j}] элемент матрицы: ");
                        while (!int.TryParse(Console.ReadLine(), out array[i, j]))
                        {
                            Console.Clear();
                            Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"Введите [{i}][{j}] элемент матрицы: ");
                        }
                        Console.Clear();
                    }
                }
                return array;

            case 2:
                Random rand = new Random();
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                        array[i,j] = rand.Next(-9,10);
                }
                return array;

            default:
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("[1] Инициализировать матрицу с клавиатуры");
                Console.WriteLine("[2] Инициализировать матрицу автоматически");
                goto flag1;
        }
    }

    public static void showMatrix(int[,] array, int rowCount, int colCount)
    {
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write($"{array[i, j]}   ");
            }
            Console.WriteLine("");
        }
    }

    public static void showMenu()
    {
        Console.WriteLine("[1] Найти количество положительных/отрицательных чисел в матрице");
        Console.WriteLine("[2] Сортировка элементов матрицы построчно (в двух направлениях)");
        Console.WriteLine("[3] Инверсия элементов матрицы построчно");
        Console.WriteLine("[4] Выход");
    }

    public static (int, int) findNegativeAndPositive(int[,] array, int rowCount, int colCount)
    {
        int countNegative = 0, countPositive = 0;

        for(int i = 0; i < rowCount; i++)
        {
            for(int j = 0; j < colCount; j++)
            {
                if (array[i, j] > 0)
                    countPositive++;
                else if (array[i, j] < 0)
                    countNegative++;
            }
        }
        return (countNegative, countPositive);
    }

    public static void bubbleSort(ref int[] array)
    {
        int temp;
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    public static void insertRow(ref int[,] array, int[] row, int colCount, int n)
    {
        for(int i = 0; i < colCount; i++)
            array[n, i] = row[i];
    }
    public static void reverseRow(ref int[] row, int length)
    {
        int temp;
        for(int i = 0; i != length / 2; i++)
        {
            temp = row[i];
            row[i] = row[length - 1 - i];
            row[length - 1 - i] = temp;
        }
    }
}
