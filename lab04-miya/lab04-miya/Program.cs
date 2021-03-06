﻿using System;

namespace lab04_miya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PolarBear Antarctic = new PolarBear(2, 4);
            Antarctic.Eat();

            Gazelle Dama = new Gazelle(2, 4);
            Dama.IsPrey();
            Dama.Eat();

            Gorilla HiddenMist = new Gorilla(2, 2);
            HiddenMist.Eat();
            HiddenMist.HasTail();

            Penguin Subarctic = new Penguin(2, 2);
            Subarctic.Eat();
            
            Console.WriteLine();

            Console.Read();
        }
    }
}

//## Directions

//- Using the Object Oriented Principles(OOPs) you learned today(Inhertiance and Abstraction)
//- Build out the hierarchical class structure of a zoo.There should be at least 3 layers of inheritance with at least 6 different types of animals.
//- Show inheritance by using `Console.WriteLine()` as neccesary to prove that a methods were propertly implemented or inherited.
//    - Examples include: `Eat()` `Sleep()` `Sound()` etc...
//    - You are allowed to use these example methods, along with others not listed
//- Be sure to include a diagram with your solution of how your zoo is mapped out. 
//- Label the abstract methods and classes as neccesary and be sure to clearly show the inheritance levels.

//## Components
//- Have at least 3 different abstract classes
//- Have at least 3 layers of inheritance
//- Have at least 3 abstract methods(each in different classes)
//- Each class you define should have at least 3 methods in it.

//- Your drawing of your zoo diagram should be clearly labeled of which classes
//- To 'prove' your inheritance, use `Console.WriteLine()` to output to the console.

//## ReadMe
//- Your readme should include the following information:
//	- How long did it take you to complete this assignment?
//	- What did you struggle with? Why? How did you solve?
//	- What did you learn during this assignment?
//    - What resources did you utilize for this assingment?