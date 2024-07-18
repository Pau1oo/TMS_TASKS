using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }   
    }
}
