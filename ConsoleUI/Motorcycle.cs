using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public override void DriveAbstract() //is abstract in vehicle so it must be implementd because it is inhereted from vehicle
        {
            Console.WriteLine("The motorcycle is driving");

        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's Virtual Drive Method");
        }
    }
}
