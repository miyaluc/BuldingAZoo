using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    class Gazelle : Desert
    {
        public Gazelle(int eyes, int legs) : base(eyes, legs)
        {
            eyes = 2;
            legs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("I'm guessing gazelles eat grass...?");
            //throw new NotImplementedException();
        }
    }
}
