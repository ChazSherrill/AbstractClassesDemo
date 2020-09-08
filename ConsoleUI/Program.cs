using System;
using System.Collections.Generic;

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

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> myListOfVehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var batmobile = new Car();

            batmobile.Make = "Uhmm not sure";
            batmobile.Model = "Also drawing a blank here.";
            batmobile.Year = "This year.";

            var robincycle = new Motorcycle();

            Vehicle mrFreezThing = new Car();

            Vehicle ridlerScooter = new Motorcycle();

            myListOfVehicles.Add(batmobile);
            myListOfVehicles.Add(robincycle);
            myListOfVehicles.Add(mrFreezThing);
            myListOfVehicles.Add(ridlerScooter);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            foreach (var t in myListOfVehicles)
            {
                t.Make = "WhoKnows?";
                t.Model = "I really don't konw";
                t.Year = "Probably fairly recent";
            }

            // Call each of the drive methods for one car and one motorcycle

            batmobile.DriveAbstract();
            batmobile.DriveVirtual();
            robincycle.DriveVirtual();
            robincycle.DriveAbstract();


            #endregion            
            Console.ReadLine();
        }
    }
}
