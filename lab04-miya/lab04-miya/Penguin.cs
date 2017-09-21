using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    class Penguin : Tundra
    {
        public Penguin(int eyes, int legs) : base(eyes, legs)
        {
            eyes = 2;
            legs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Penguins eat fish too.");
            //throw new NotImplementedException();
        }
    }
}
