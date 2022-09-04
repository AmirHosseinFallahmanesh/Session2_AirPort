using System;

namespace Part4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] data = new string[4] { "ali", "reza", "mina", "sina" };
            Console.WriteLine("Enter Search");
            string search = Console.ReadLine();

            bool find = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (search == data[i])
                {
                    find = true;
                    break;
                }

            }
            //var = condition ? true value : false value;


            //string result = find ? "Name Found" : "Name Not Found";

            Console.WriteLine(find ? "Name Found" : "Name Not Found");
        }
    }
}
