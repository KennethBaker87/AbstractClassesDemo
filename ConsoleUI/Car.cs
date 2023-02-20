using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract() //is abstract in vehicle so it must be implementd because it is inhereted from vehicle
        {
            Console.WriteLine("The car is driving");
        }
    }
}
