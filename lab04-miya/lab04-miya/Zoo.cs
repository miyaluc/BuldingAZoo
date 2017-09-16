using System;
using System.Collections.Generic;
using System.Text;

namespace lab04_miya
{
    abstract class Zoo
    {
        public string Color
        {
            get; set;
        }
        public int Eyes
        {
            get; set;
        }
        public int Legs
        {
            get; set;
        }
        public bool Claws
        {
            get
            {
                return true;
            }
            set
            {
                {
                };
            }
        }

        public Zoo(string coloring)
        {
            Color = coloring;
            Console.WriteLine("What a gorgeous beast!");
        }
        public Zoo(int eyes, int legs)
        {
            Eyes = 2;
            Legs = 4;
        }
        public abstract void Eat();

        public void Attack(string claws)
        {
            Claws = true;
            if (Claws)
            {
                Console.WriteLine("Back away! That animal has claws and they hurt!");
            }
        }
        public bool IsPrey()
        {
            bool prey = true;
            return prey;
        }
    }
}