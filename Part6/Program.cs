using System;
using System.Linq;

namespace Part6
{
    //average
    //failed Count
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mark Count");
            int count = Convert.ToInt32(Console.ReadLine());
            double[] marks = new double[count];

            Console.WriteLine("***************** get marks ********************");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter Mark");
                marks[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("***************** get average ********************");
            
            double average = marks.Sum() / marks.Length;
            Console.WriteLine($"The Average is {average}");

            Console.WriteLine("***************** get failed Count ********************");

            int counter = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i]<10)
                {
                    counter++;
                }
            }
            Console.WriteLine($"the {counter} mark is failed");

        }
    }
}
