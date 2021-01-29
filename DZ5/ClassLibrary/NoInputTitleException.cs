using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class NoInputTitleException : Exception
    {
        public NoInputTitleException(string message) : base(message)
        {

        }
    }
}
