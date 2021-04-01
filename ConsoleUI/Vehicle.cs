using System;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        
        // Vehicle shall have an abstract method called  with no implementation
        public abstract void DriveAbstract();
        
        // Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a good car");
        }
    }
}