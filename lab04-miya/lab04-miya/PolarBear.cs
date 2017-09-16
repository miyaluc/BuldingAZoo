using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    class PolarBear : Tundra
    {
        public PolarBear(int eyes, int legs) : base(eyes, legs)
        {
            eyes = 2;
            legs = 4;
            Console.WriteLine($"I've got {eyes} eyes and {legs} legs.");
        }

        public override void Eat()
        {
            //throw new NotImplementedException();
        }
    }
}
