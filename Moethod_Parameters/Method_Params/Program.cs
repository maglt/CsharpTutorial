using System;

namespace Method_Params
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] g = new int[3];

            g[0] = 2;
            g[1] = 3;
            g[2] = 4;

            void Hello(params int[] a)
            {
              foreach (int p in a)
                {
                    Console.WriteLine(p);
                }
            }

            Hello(g); // pass array of ints like this


            Hello(100,200,300); // or pass list of numbers like this


        }
    }
}
