using System;

namespace Part14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ma = new int[3][];
            ma[0] = new int[3] { 10, 20, 30 };
            ma[1] = new int[7] { 10, 20, 30,40,50,60,70 };
            ma[2] = new int[1] { 10 };

            //ma[0][0] = 10;
            Console.WriteLine("the length of ma is "+ma.Length);
            Console.WriteLine("the length of ma[0] is "+ma[0].Length);
            Console.WriteLine("the length of ma[1] is "+ma[1].Length);
            Console.WriteLine("the length of ma[2] is "+ma[2].Length);
            Console.WriteLine(  );
            for (int i = 0; i < ma.Length; i++)
            {
                for (int j = 0; j < ma[i].Length; j++)
                {
                    Console.WriteLine($"ma[{i}][{j}] = {ma[i][j]}");
                }
            }
         
        }
    }
}
