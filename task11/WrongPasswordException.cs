using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message)
            : base(message) { }
    }
}
