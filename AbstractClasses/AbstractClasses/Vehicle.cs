using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Vehicle
    {
        public int Id { get; set; }

        public abstract string Name { get; set; }

        public abstract void Drive();

        public void Driving()
        {
            Console.WriteLine("Vehicle is driving");
        }

  
    }
}
