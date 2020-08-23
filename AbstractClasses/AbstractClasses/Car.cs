using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Car : Vehicle
    {
        public override string  Name { get; set; }

        public override void Drive()
        {
            Console.WriteLine("car is driving");
        }



    }
}
