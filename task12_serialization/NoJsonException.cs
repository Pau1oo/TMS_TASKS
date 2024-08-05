using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12_serialization
{
    public class NoJsonException : Exception
    {
        public NoJsonException(string message)
            : base(message) { }
    }
}
