using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Person
    {
        public int Age;

        public virtual void Greet()
        {
            Console.WriteLine("Привет!");
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
