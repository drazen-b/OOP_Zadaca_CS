using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ImageModel
    {
        public string Medium { get; private set; }
        public string Original { get; private set; }
        public ImageModel(string medium, string original)
        {
            Medium = medium;
            Original = original;
        }

    }
}
