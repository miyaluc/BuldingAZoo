using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    abstract class Antarctica : Zoo
    {
        public Antarctica(int eyes, int legs) : base(eyes, legs)
        {
            Eyes = eyes;
            Legs = legs;
        }

        public bool Furred
        {
            get; set;
        }
    }
}
