using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public bool HasTrunk;

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm theoretically driving with a car.");
        }
    }
}
