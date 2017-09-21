using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    abstract class Desert : Africa
    {
        public Desert(int eyes, int legs) : base(eyes, legs)
        {
            eyes = 0;
            legs = 0;
        }
    }
}
