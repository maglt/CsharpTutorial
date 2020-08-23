using System;
using System.Threading.Tasks;
using System.Threading;

//https://www.youtube.com/watch?v=5Fjt3dhXEqU

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThings();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

       public static async void DoThings()
        {
            
          // run these two methods first
          Task<bool> result =  CookEggs();
          CookBacon();


            //run this metohd last if first method finishes with true
           bool resultm = await result;
           if (resultm = true)
            {
                CookBread();
            }

     
       
    }


        public static async Task<bool> CookEggs()
        {
            bool result = true;
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Eggs cooked");
            });
            return result;
        }

        public static async Task<bool> CookBacon()
        {
            bool result = true;
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Bacon cooked");
            });
            return result;
        }

        public static async Task<bool> CookBread()
        {
            bool result = true;
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Bread cooked");
            });
            return result;
        }


    }
}