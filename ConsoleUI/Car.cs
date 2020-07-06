using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public int NumDoors { get; set; }
        public bool HasAirConditioning { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"{this.Make} takes off down the road");
        }
    }
}
