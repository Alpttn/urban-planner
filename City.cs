using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string NameOfCity { get; set; }
        public int YearEstablished { get; set; }
        public string Mayor { get; set; }

        public List<Building> Buildings = new List<Building>();
        

        
        
    };
}