using System;

namespace Assessment.Inheritance
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class inheriting from Animal
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

}
