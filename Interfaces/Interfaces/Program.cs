using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List <IFlyable> flist = new List<IFlyable>();

            flist.Add(new Bird("Sakalas"));
            flist.Add(new Bird("Zyle"));
            flist.Add(new Plane("Boeing 747"));
            flist.Add(new Plane("Mazas lektuvelis"));

            foreach(IFlyable bb in flist)
            {
                bb.Fly(bb.Name);
            }


        }
    }
}
