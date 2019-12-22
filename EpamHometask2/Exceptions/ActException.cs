using System;
using System.Collections.Generic;
using System.Text;

namespace EpamHometask2
{
    class ActException : Exception
    {
        public ActException(string message) : base(message) { }
        public ActException() : base() { }
    }
}
