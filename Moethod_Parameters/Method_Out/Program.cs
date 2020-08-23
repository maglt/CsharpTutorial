using System;

namespace Method_Out
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 5;
            int a = 1;

            void Hello(out int i, out int a)
            {
                i = 25;
                a = 2;
                Console.WriteLine($"Hello World {i}");
            }

            Hello(out i, out a);

            Console.WriteLine($"Hello World {i},{a}"); // just out, can output multiple values
            Console.ReadLine();
        }
    }
}
