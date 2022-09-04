using System;

namespace Part2
{   //while -> check condition then run body
    //do while -> run body then check condition 
    class Program
    {
        static void Main(string[] args)
        {
            string input = "q";
            do
            {
                Console.WriteLine("You Entered "+input);
                Console.WriteLine("Enter Text Or Press q To Exit");
                input = Console.ReadLine();
            } while (input!="q");

            Console.WriteLine("Continue");
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
