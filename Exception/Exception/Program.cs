using System;
using System.IO;

namespace Exception2
{
    class Program
    {
        static void Main(string[] args)
        {

        //place general Exception ex in the bottom it will fire if all other more specific catches won't catch
            try
            { 
            Console.WriteLine("Hello World!");
                throw new DivideByZeroException();
            }
            catch (OutOfMemoryException oter)
            {
                Console.WriteLine("pp");
            }
            catch (DivideByZeroException div)
            {
                Console.WriteLine("dd");
            }
            catch (Exception ex)
            {
                Console.WriteLine("yy");
            }
    }
    }
}
