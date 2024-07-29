using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task8
{
    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Я объсняю.");
        }

        public override void Greet()
        {
            Console.WriteLine("Привет, я учитель.");
        }
    }
}
