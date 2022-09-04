using System;

namespace Part12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mts1 = new int[2, 2];
            int[,] mts2 = new int[2, 2];
            int[,] sum = new int[2, 2];

            for (int i = 0; i < mts1.GetLength(0); i++)
            {
                for (int j = 0; j < mts1.GetLength(1); j++)
                {
                    Console.Write($"Enter mts1[{i},{j}] ");
                    mts1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < mts2.GetLength(0); i++)
            {
                for (int j = 0; j < mts2.GetLength(1); j++)
                {
                    Console.Write($"Enter mts2[{i},{j}] ");
                    mts2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine();
            for (int i = 0; i < mts2.GetLength(0); i++)
            {
                for (int j = 0; j < mts2.GetLength(1); j++)
                {
                    sum[i, j] = mts1[i, j] + mts2[i, j];
                    Console.WriteLine($"sum[{i},{j}] = {sum[i,j]} ");
                }

            }
            Console.WriteLine();
            int det = (sum[0, 0] * sum[1, 1]) - (sum[0, 1] * sum[1, 0]);

            Console.WriteLine("det is "+det);
        }
    }
}
