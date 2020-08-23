using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Plane : IFlyable
    {
        public string Name { get; set; }

        public Plane(string Name)
        {
            this.Name = Name;
        }

        public void Fly(string name)
        {
            Console.WriteLine($"Plane {name} flies");
        }
    }
}
