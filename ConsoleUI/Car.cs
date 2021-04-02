using System;

namespace ConsoleUI
{
    public class Car : Vehicle

    {
        /* 
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
        */

        public Car()
        {
        }
        
        //Add a distict property derived class such as HasTrunk for Car
        public bool HasTrunk { get; set; } = true;
        // 
        public override void DriveAbstract()
        {
            Console.WriteLine("Let's ride!");
        }
    }
}