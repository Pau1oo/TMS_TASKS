namespace task10
{
    class Program
    {
        public static int input()
        {
            int num;
            Console.WriteLine("Введите число:");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Введите число:");
            }
            Console.Clear();
            return num;
        }
        static void Main()
        {
            ComparablePair<int, int> pair1 = new ComparablePair<int, int>(input(), input());
            ComparablePair<int, int> pair2 = new ComparablePair<int, int>(input(), input());

            Console.WriteLine($"Первая пара - {pair1.t_value}, {pair1.u_value}\n" +
                              $"Вторая пара - {pair2.t_value}, {pair2.u_value}");

            if (pair1.CompareTo(pair2) == 0 ) 
            {
                Console.WriteLine("Пары равны!");
            }
            else if(pair1.CompareTo(pair2) == 1)
            {
                Console.WriteLine("Первая пара больше!");
            }
            else if (pair1.CompareTo(pair2) == -1)
            {
                Console.WriteLine("Вторая пара больше!");
            }
        } 
    }
}
