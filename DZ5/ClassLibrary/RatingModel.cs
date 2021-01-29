using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class RatingModel
    {
        public double Average{ get; private set; }

        public RatingModel(double average)
        {
            Average = average;
        }



    }
}
