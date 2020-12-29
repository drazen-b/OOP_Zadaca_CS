using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Class_Library
{
    public class FilePrinter : IPrinter
    {
        public string FileName;

        public FilePrinter(string FileName)
        {
            this.FileName = FileName;
        }
        public void Print(string Text)
        {
            using (System.IO.StreamWriter writer = new StreamWriter(FileName))
            {
                writer.WriteLine(Text);
            }
        }
    }
}
