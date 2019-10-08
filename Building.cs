using System;

namespace Planner
{
    public class Building 
    {
        private string _designer = "Allie";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "301 plus park blvd";
        private string _owner = "John";

        //public
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume 
        {
            get
            {
                return Width * Depth *(3 * Stories);
            }
        }

        //constructor
        public Building(string buildingAddress)
        {
            _address = buildingAddress;
        }
        //methods

        public void Construct() 
        {
            _dateConstructed = DateTime.Now;
        }

        //need to create methods to return the info needed
         public void Purchase(string newOwner) //methods
        {
            _owner = newOwner;
        }

        public string GetDesigner()
        {
            return _designer;
        }
        public string GetAddress()
        {
            return _address;
        }
        public DateTime GetDate()
        {
            return _dateConstructed;
        }
        public string GetOwner()
        {
            return _owner;
        }
    

    }
}