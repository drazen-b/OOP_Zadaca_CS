using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Description
    {
        public int EpNumber { get; private set; }
        public TimeSpan EpDuration { get; private set; }
        public string EpName { get; private set; }

        public Description(int EpNumber, TimeSpan EpDuration, string EpName)
        {
            this.EpNumber = EpNumber;
            this.EpDuration = EpDuration;
            this.EpName = EpName;
        }

        public Description(Description other)
        {
            this.EpNumber = other.EpNumber;
            this.EpName = other.EpName;
            this.EpDuration = other.EpDuration;
        }

        public override string ToString()
        {
            return $"{this.EpNumber},{this.EpDuration},{this.EpName}";
        }

    }
}
