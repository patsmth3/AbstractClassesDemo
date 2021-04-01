using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles
            
            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var avalon = new Car() {HasTrunk = true, Make = "Toyota", Model = "Avalon", Year = 2016};
            var fz6r = new Motorcycle() {HasSideCart = false, Make = "Yamaha", Model = "FZ6R", Year = 2017};

            Vehicle sedan = new Car() {HasTrunk = true, Make = "Honda", Model = "Accord", Year = 2019};
            Vehicle sport = new Car() {HasTrunk = true, Make = "Porsche", Model = "Cayman", Year = 2017};
           
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(avalon);
            vehicles.Add(fz6r);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make} Model {vehicle.Model} Year {vehicle.Year}");
                vehicle.DriveAbstract();
                Console.WriteLine("--------------------------------------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
