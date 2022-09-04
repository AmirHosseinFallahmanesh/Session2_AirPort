using System;
//A method is a group of statements that together perform a task
//return type methodName(datatype1 p1,datatype2 p2,...)
//method definition must be inside the class 


namespace Part15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();

            weclomeWithFullName(firstName, lastName);


        }

        static void welcome()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("welcome to my app");
        }

        static void weclomeWithName(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("welcome to my app");
        }
        static void weclomeWithFullName(string name,string surname)
        {
            Console.WriteLine($"Hello {name} {surname}");
            Console.WriteLine("welcome to my app");
        }

    }
}
