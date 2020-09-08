using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCar;

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm theoretically driving with a motorcycle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"When I'm in a motorcycle I also like to drive virtually");
        }
    }
}
