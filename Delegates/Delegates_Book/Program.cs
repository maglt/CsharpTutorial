using System;

namespace Delegates_Book
{

    delegate void delas(); //declare delegate
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee m = new Employee("Jonas", 18); //create instace of a class
            Customer c = new Customer("Peter", 1989); // create instace of another class

             delas del; // decalre delegate variable

            // add methods to delegate even from different classes
            del = m.ShowAge;
            del += m.ShowName;
            del += c.ShowSurname;
            del += c.ShowCustomerId;

            del(); // execute all methods at once

            Console.ReadLine();



        }
    }



    public class Employee
    {
        public string Name { get; set; }
        public int  Age { get; set; }

        public Employee(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void ShowAge()
        {
            Console.WriteLine($"Employee age is: {Age}");
        }


        public void ShowName()
        {
            Console.WriteLine($"Employee name is: {Name}");
        }

    }

    public class Customer
    {
        public  string Surname { get; set; }
        public int CustomerId { get; set; }


        public Customer(string Surname, int CustomerId)
        {
            this.Surname = Surname;
            this.CustomerId = CustomerId;
        }



        public void ShowSurname()
        {
            Console.WriteLine($"Employee asurname is: {Surname}");
        }


        public void ShowCustomerId()
        {
            Console.WriteLine($"Employee customer id is: {CustomerId}");
        }

    }
}
