using System;

namespace Part18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 25, 36, 12, 14)); 
            Console.WriteLine(Sum(10, 25));
            Console.WriteLine(Sum(10, 25,43));
        }

        static int Sum(params int[] numbers)
        {
            int res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res += numbers[i];
            }
            return res;
        }
    }
}
