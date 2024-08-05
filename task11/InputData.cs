using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class InputData
    {
        public static bool Verify(string Login, string Password, string ConfirmPassword)
        {
            if(Login.Contains(' ') || Login.Length > 20)
            {
                throw new WrongLoginException("Исключение WrongLoginException");
            }
            if (Password.Contains(' ') || Password.Length > 20 || !Password.Any(char.IsDigit) || !Password.Equals(ConfirmPassword))
            {
                throw new WrongPasswordException("Исключение WrongPasswordException");
            }
            return true;
        }

        public static string Input(string dataType)
        {
            string? str;
            Console.WriteLine($"Введите {dataType}:");
            str = Console.ReadLine();
            Console.Clear();
            return str;
        }
    }
}
