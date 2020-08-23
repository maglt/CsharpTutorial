using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Bird : IFlyable
    {
        public string Name { get; set; }

        public Bird(string Name)
        {
            this.Name = Name;
        }

        public void Fly(string name)
        {
            Console.WriteLine($"Bird {name} flies");
        }
    }
}
