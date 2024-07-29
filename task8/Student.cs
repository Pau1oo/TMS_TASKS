using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Я учусь.");
        }

        public override void Greet()
        {
            Console.WriteLine("Привет, я студент(ка).");
        }

        public void ShowAge()
        {
            Console.WriteLine($"Мой возраст: {Age} лет");
        }
    }
}
