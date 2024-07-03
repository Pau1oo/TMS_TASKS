using System;
using System.Data;

class Program
{
    public static int input(string selection)
    {
        int row, col;
        switch(selection)
        {
            case "rows":
                while (!int.TryParse(Console.ReadLine(), out row))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Введите кол-во строк:");
                }
                Console.Clear();
                return row;

            case "cols":
                while (!int.TryParse(Console.ReadLine(), out col))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Введите кол-во строк:");
                }
                Console.Clear();
                return col;
        }
        return 0;
    }

    public static int[,] initializeMatrix(int row, int col)
    {
        int selection;
        Console.WriteLine("[1] Инициализировать матрицу с клавиатуры");
        Console.WriteLine("[2] Инициализировать матрицу автоматически");
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


        int[,] array = new int[row, col];
        switch (selection)
        {
            case 1:
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
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
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        array[i,j] = rand.Next(0,10);
                    }
                }
                return array;
        }
        return array;
    }

    public static void showMatrix(int[,] array, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine("");
        }
    }
    static void Main()
    {
        int row, col;
        Console.WriteLine("Введите кол-во строк: ");
        row = input("rows");

        Console.WriteLine("Введите кол-во столбцов: ");
        col = input("cols");

        int[,] matrix = initializeMatrix(row, col);

        showMatrix(matrix, row, col);
    }
}
