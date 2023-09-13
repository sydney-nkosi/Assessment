using System;

namespace Assessment.Inheritance
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    class Car : Vehicle
    {
    }

    class Sedan : Car
    {
    }

}
