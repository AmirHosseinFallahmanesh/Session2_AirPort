using System;

namespace Partt13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Enter n");
            //int n = int.Parse(Console.ReadLine()); ;
            //Console.WriteLine("Enter m");
            //int m= int.Parse(Console.ReadLine()); ;
            //int[,] ma = new int[m, n];
            //for (int i = 0; i < ma.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ma.GetLength(1); j++)
            //    {
            //        ma[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            int[,] ma = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };

            int[,,] mb = new int[2, 3, 2];
            mb[0, 0, 0] = 10;
            mb[0, 0, 1] = 20;
            mb[0, 1, 0] = 30;
            mb[0, 1, 1] = 40;
            mb[0, 2, 0] = 50;
            mb[0, 2, 1] = 60;

            mb[1, 0, 0] = 70;
            mb[1, 0, 1] = 80;
            mb[1, 1, 0] = 90;
            mb[1, 1, 1] = 100;
            mb[1, 2, 0] = 110;
            mb[1, 2, 1] = 120;

            for (int i = 0; i < mb.GetLength(0); i++)
            {
                for (int j = 0; j < mb.GetLength(1); j++)
                {
                    for (int k = 0; k < mb.GetLength(2); k++)
                    {
                        Console.WriteLine($"array[{i},{j},{k}] = {mb[i, j, k]} ");
                    }
                }
            }


            int[,,] mc = new int[2, 3, 2] {
                { { 10,20},{30,40 },{50,60 } },
                { { 70,80}, { 90,100}, {110,120 }}
            };


        }
    }
}
