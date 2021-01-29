using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class NetworkModel
    {
        public string Name { get; private set; }

        public NetworkModel(string name)
        {
            Name = name;
        }

    }
}
