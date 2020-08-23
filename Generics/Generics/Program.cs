using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Belekas.Vienodi(10, 10)); //call generic method
            Console.WriteLine(BelekasGen<int>.Vienodi(10, 12)); //call generic class method
        }

        public class Belekas
        {
            public static bool Vienodi<T>(T Pirmas, T Antras) //generic method
            {
                return Pirmas.Equals(Antras);
            }
        }


        public class BelekasGen<T> 
        {
            public static bool Vienodi(T Pirmas, T Antras) //generic class
            {
                return Pirmas.Equals(Antras);
            }
        }
    }
}
