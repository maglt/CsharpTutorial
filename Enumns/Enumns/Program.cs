using System;

namespace Enumns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Hello World! {Gender.Male}");
        }
    }


    public enum Gender
    {
        Male,
        Female,
        Whatever
    }
}
