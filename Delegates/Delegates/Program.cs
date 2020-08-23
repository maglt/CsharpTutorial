using System;
using System.Collections.Generic;




/*Open for Extension, Closed for Modification.
/*

Rapolas DElegates Usage:

1. With events impelement a publish subscribe system, for decoupling your application.
2. You can add multiple method pointers from different classes to delegate and then execute them at once with a deligate call.
3. You can make class method more flexible by using deligate as parameter to method. This way user don't have to modify base class to change the logic. Ex: PromoteEmployee has different criterios in each company, so you can pass deligate wih bool return type and use this bool in your base class method.

You want to call series of method by using single delegate without writing lot of method calls.
You want to implement event based system elegantly.
You want to call two methods same in signature but reside in different classes.
You want to pass method as a parameter.
You don't want to write lot of polymorphic code like in LINQ , you can provide lot of implementation to the Select method.

/*

A delegate can be seen as a placeholder for a/some method(s).

By defining a delegate, you are saying to the user of your class, "Please feel free to assign, any method that matches this signature, to the delegate and it will be called each time my delegate is called".
Delegates are extremely useful, especially after the introduction of linq and closures.

A good example is the 'Where' function, one of the standard linq methods. 'Where' takes a list and a filter, and returns a list of the items matching the filter. (The filter argument is a delegate which takes a T and returns a boolean.)

Because it uses a delegate to specify the filter, the Where function is extremely flexible. You don't need different Where functions to filter odd numbers and prime numbers, for example. The calling syntax is also very concise, which would not be the case if you used an interface or an abstract class.

More concretely, Where taking a delegate means you can write this:

var result = list.Where(x => x != null);
...
instead of this:

var result = new List<T>();
foreach (var e in list)
    if (e != null)
        result.add(e)

...


Now that we have lambda expressions and anonymous methods in C#, I use delegates much more. In C# 1, where you always had to have a separate method to implement the logic, using a delegate often didn't make sense. These days I use delegates for:

Event handlers (for GUI and more)
Starting threads
Callbacks (e.g. for async APIs)
LINQ and similar (List.Find etc)
Anywhere else where I want to effectively apply "template" code with some specialized logic inside (where the delegate provides the specialization)

*/

namespace Delegates
{

    public delegate void HelloDelas(string del); //declare delegate  (type safe function pointer, meaning function and delegate should be same return type)
    public delegate bool EmpDelas(Employee n);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelas del = new HelloDelas(HelloWorld); //assing delegate to function

            del("belekas"); //execute delegate


            List<Employee> mList = new List<Employee>();

            mList.Add(new Employee(20, "Jonas", 100));
            mList.Add(new Employee(29, "Paula", 90));
            mList.Add(new Employee(38, "Franiek", 80));
            mList.Add(new Employee(49, "Gulben", 101));


            /*     static bool SalaryOverHundred (Employee em) // csutom logic
                 {
                     if (em.Salary >= 100)
                         return true;
                     else return false;
                 }


                 EmpDelas empDelas = new EmpDelas(SalaryOverHundred);  //assing delegate to function

                 Employee.ShowSalary(mList, empDelas); // passing custom logic as parameter to our method
            */

            Employee.ShowSalary(mList, emp => emp.Salary >= 100); //passing logic to our class method, no need to modify the class we can pass logic as parmeter with delegate


            Console.ReadLine();
        }

        public static void HelloWorld(string hello)
        {
            Console.WriteLine(hello);
        }


  
    }


    public class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public  Employee(int Age, string Name, int Salary)
        {
            this.Age = Age;
            this.Name = Name;
            this.Salary = Salary;

        }

 

        public static void ShowSalary(List<Employee> empList,EmpDelas empasD)
        {
            foreach (Employee emp in empList)
            {
                if (empasD(emp))
                {
                    emp.Salary = emp.Age * 100 / 29;
                    Console.WriteLine($"{emp.Name} salary is {emp.Salary}");
                }
                else
                    Console.WriteLine("Less than 100");
            }

        }
    }


}





