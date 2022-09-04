using System;

namespace Part11
{
    //multi dimentional array
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ma = new int[2, 3];
            ma[0, 0] = 10;
            ma[0, 1] = 20;
            ma[0, 2] = 30;

            ma[1, 0] = 40;
            ma[1, 1] = 50;
            ma[1, 2] = 60;

            Console.WriteLine("ma [1,1] "+ma[1,1]);
            Console.WriteLine("the size of ma is "+ma.Length);
            Console.WriteLine("the size of d0 => "+ma.GetLength(0));
            Console.WriteLine("the size of d1 => "+ma.GetLength(1));

            Console.WriteLine("Print Data ...");
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.WriteLine($"ma[{i},{j}] = {ma[i,j]}");
                }
            }
        }
    }
}
