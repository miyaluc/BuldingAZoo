using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    abstract class Africa : Zoo
    {
        public Africa(int eyes, int legs) : base(eyes, legs)
        {
            Eyes = eyes;
            Legs = legs;
        }
        public int NumberofLegs(int legs)
        {
            legs = 4;
            Console.WriteLine($"A lion has {legs} legs.");
            return legs;
        }
    }
}
