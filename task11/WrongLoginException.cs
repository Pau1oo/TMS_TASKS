﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException(string message) 
            : base(message) { }
    }
}
