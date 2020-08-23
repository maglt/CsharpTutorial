using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Mokinys> dick = new Dictionary<int, Mokinys>();

            Mokinys mok = new Mokinys("Jonas", 10);

            dick.Add(mok.Id, mok);
            dick.Add(1, mok);
            dick.Add(2, mok);


            foreach ( KeyValuePair<int,Mokinys> d in dick)
            {
                Console.WriteLine(d.Key + " "  + d.Value.Name);
            }

            Mokinys rastasMokinys = dick.ContainsKey(1) ? dick[1] : null; // dictionary LOOKUP, if not found in dictionary than rastasMokinys will be null

            Console.WriteLine(rastasMokinys);

        }
    }


    public class Mokinys
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Mokinys(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }
}
