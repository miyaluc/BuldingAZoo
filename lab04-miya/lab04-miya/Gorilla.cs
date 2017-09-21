using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    class Gorilla : Jungle
    {
        public Gorilla(int eyes, int legs) : base(eyes, legs)
        {
            eyes = 2;
            legs = 2;
        }

        public override void Eat()
        {
            Console.WriteLine("I believe gorillas are herbivores. Don't quote me though!");
            //throw new NotImplementedException();
        }
        public bool HasTail()
        {
            Console.WriteLine("Gorillas don't need tails. They walk upright like humans.");
            return false;
        }
    }
}
