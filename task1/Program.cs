Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите отчество: ");
string fname = Console.ReadLine();

string[] keys = { surname, name, fname };

string fullName = string.Join(" ", keys);
Console.WriteLine("ФИО: " + fullName);

Console.ReadKey();