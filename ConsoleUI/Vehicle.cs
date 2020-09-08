using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        

        public Vehicle()
        {
            Make = "Ford";
            Model = "Model T";
            Year = "0001";
        }
        
        //need to set a default value
        public string Year
        {
            get
            {
                return Year;
            }
            set
            {
                Make = value;
            }
        }
        //set a default value
        public string Make
        {
            get
            {
                return Make;
            }
            set
            {
                Make = value;
            }
        }
        
        public string Model
        {
            get
            {
                return Model;
            }
            set
            {
                Make = value;
            }
        }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {

        }
    }
}
