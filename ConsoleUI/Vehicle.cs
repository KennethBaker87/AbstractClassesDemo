using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //abstract class is a partial template
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "Default Value";
        public string Make { get; set; } = "Default Value";
        public string Model { get; set; } = "Default Value";

        public abstract void DriveAbstract();// abstract methods are stubbed out method because no implementation

        public virtual void DriveVirtual()// optional to be implemented since not abstract
        {
            Console.WriteLine("Default Virtual Drive Method");
        }
    }
}
