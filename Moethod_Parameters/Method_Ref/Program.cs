using System;

namespace Method_Ref
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 5;

            void Hello(ref int i)
            {
                i++;
                Console.WriteLine($"Hello World {i}");
            }

            Hello(ref i);

            Console.WriteLine($"Hello World {i}"); //i value changed because in and out, i value changed in method, reflected in variable outside method
            Console.ReadLine();
        }
    }
}
