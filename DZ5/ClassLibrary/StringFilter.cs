using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class StringFilter
    {
        public static string FormatString(string input)
        {
            input = input.Replace("<p>", "");
            input = input.Replace("<b>", "");
            input = input.Replace("</p>", "");
            input = input.Replace("</b>", "");
            return input;
        }
    }
}
