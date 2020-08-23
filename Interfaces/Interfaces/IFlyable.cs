using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IFlyable
    {
        public string Name { get; set; }
        void Fly(string name);
    }
}
