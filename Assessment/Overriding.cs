using Assessment.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Overriding
    {
        public Overriding()
        {
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();

            animal1.MakeSound();
            animal2.MakeSound();
        }
    }
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound.");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }
}
