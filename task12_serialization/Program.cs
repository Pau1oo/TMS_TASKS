using System.Linq.Expressions;
using System.Text.Json;
using System.Xml.Serialization;
namespace task12_serialization
{
    class Program
    {
        public static int input()
        {
            int num;
            Console.WriteLine("Введите номер файла:");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Введите номер файла:");
            }
            Console.Clear();
            return num;
        }
        public static void Main()
        {
            string path = "C:\\Users\\bukat\\Projects\\TMS\\task12_serialization\\";
            string[] allJsonFiles = Directory.GetFiles(path, "*json", SearchOption.TopDirectoryOnly);
            try
            {
                if (allJsonFiles.Length == 0)
                {
                    throw new NoJsonException("В директории отсутствуют файлы .json");
                }
            }
            catch(NoJsonException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            for(int i = 1; i <= allJsonFiles.Length; i++)
            {
                //allJsonFiles[i - 1] = allJsonFiles[i - 1].Replace(path, "'");
                Console.WriteLine($"[{i}] {allJsonFiles[i - 1]}");
            }

            int selection = input();
            string jsonFileName = allJsonFiles[selection - 1];
            //jsonFileName = jsonFileName.Replace("'", path);
            string jsonString = File.ReadAllText(jsonFileName);
            Squad obj = JsonSerializer.Deserialize<Squad>(jsonString)!;

            XmlSerializer xmlser = new XmlSerializer(typeof(Squad));
            Stream serialStream = new FileStream($"{typeof(Squad).Name}.xml", FileMode.Create);
            xmlser.Serialize(serialStream, obj);

            Console.WriteLine($"JSON:\n{jsonString}");
            Console.WriteLine($"OBJECT:\n{obj.field1}, {obj.field2}, {obj.field3}");
        }
    }
}
