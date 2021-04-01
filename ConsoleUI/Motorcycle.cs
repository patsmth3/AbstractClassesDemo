using System;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        
        //Add a distict property derived class such as HasSideCart for Motorcycle
        public bool HasSideCart { get; set; } = false;
        
        // * Provide the implementations for the abstract methods
        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} and is fun to ride");
        }
    }
}