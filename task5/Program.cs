class Phone
{
    public string number;
    public string model;
    public int weight;

    public Phone(string number, string model, int weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }

    public Phone(string number, string model) : this(number, model, 0) { }

    public Phone() : this("Неизвестно", "Неизвестно", 0) { }

    public static void receiveCall(string name)
    {
        Console.WriteLine($"Звонит: {name}");
    }

    public static void receiveCall(string name, string number)
    {
        Console.WriteLine($"Звонит: {name} | Номер: {number}");
    }

    public static string getNumber(Phone phone)
    {
        return phone.number;
    }

    public static void sendMessage(params string[] numbers)
    {
        foreach(string number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

class Program
{
    public static void Main()
    {
        Phone phone1 = new Phone(number: "+375293673609", model: "Nokia 3310", weight: 267);
        Phone phone2 = new Phone(number: "+375339550328", model: "iPhone 13");
        Phone phone3 = new Phone();

        Console.WriteLine($"{phone1.number}, {phone1.model}, {phone1.weight}\n" +
            $"{phone2.number}, {phone2.model}, {phone2.weight}\n" +
            $"{phone3.number}, {phone3.model}, {phone3.weight}\n");

        string numberPhone1 = Phone.getNumber(phone1);
        string numberPhone2 = Phone.getNumber(phone2);
        string numberPhone3 = Phone.getNumber(phone3);

        Phone.receiveCall("Георгий", phone1.number);
        Phone.receiveCall("Александр", numberPhone2);
        Phone.receiveCall("Григорий", numberPhone3);

        Console.WriteLine("\n");

        Phone.sendMessage(numberPhone1, numberPhone2, numberPhone3, "+37529166804", "+37533569403");

        Console.ReadKey();
    }
}