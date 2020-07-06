using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public string HandlebarType { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle roars its engine");
        }
    }
}
