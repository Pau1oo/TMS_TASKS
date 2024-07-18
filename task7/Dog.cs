using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Dog : Animal
    {
        public override void Eat() => Console.WriteLine($"Собака по кличке \"{Name}\" ест");
    }
}
