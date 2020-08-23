using System;

namespace Method_P_Value
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 5;

            void Hello(int i)
            {
                i++;
                Console.WriteLine($"Hello World {i}");
            }

            Hello(i);

            Console.WriteLine($"Hello World {i}");
            Console.ReadLine();
        }
    }
}
