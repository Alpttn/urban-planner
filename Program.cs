using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 500;
            FiveOneTwoEigth.Depth = 500;
            FiveOneTwoEigth.Stories = 4;
            FiveOneTwoEigth.Construct();
            
            Building FiveOneTwoNine = new Building("512 9th Avenue");
            FiveOneTwoNine.Width = 1000;
            FiveOneTwoNine.Depth = 1000;
            FiveOneTwoNine.Stories = 8;
            FiveOneTwoNine.Construct();

            Building FiveOneTwoSeven = new Building("512 7th Avenue");
            FiveOneTwoSeven.Width = 1200;
            FiveOneTwoSeven.Depth = 1200;
            FiveOneTwoSeven.Stories = 6;
            FiveOneTwoSeven.Construct();

            List<Building> city = new List<Building>();
            city.Add(FiveOneTwoEigth);
            city.Add(FiveOneTwoNine);
            city.Add(FiveOneTwoSeven);

            FiveOneTwoEigth.Purchase("Bruce Wayne");
            FiveOneTwoNine.Purchase("Penguin");
            FiveOneTwoSeven.Purchase("Jim Gordon");

            foreach (Building building in city)
            {
                Console.WriteLine();
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("--------------");
                Console.WriteLine($"Designed by {building.GetDesigner()}");
                Console.WriteLine($"Constructed on {building.GetDate()}");
                Console.WriteLine($"Owned by {building.GetOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space ");
                Console.WriteLine();

            }

        }
    }
}
