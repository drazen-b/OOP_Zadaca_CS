using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class TvException : Exception
    {
        public string Title { get; private set; }
        public TvException(string epName, string message) : base(message)
        {
            Title = epName;
        }
    }
}
