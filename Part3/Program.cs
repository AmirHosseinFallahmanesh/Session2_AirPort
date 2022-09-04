using System;
//array in reference type
//new -> allocate in Heap
namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype[] name=new datatype[length];
            int[] ma = new int[4];
            ma[0] = 10; //assagement
            ma[1] = 20;
            ma[2] = 30;
            ma[3] = 40;

            Console.WriteLine("ma [2] => "+ma[2]);
            Console.WriteLine("ma size is "+ma.Length);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ma list =>");
            for (int i = 0; i < ma.Length; i++)
            {
                Console.WriteLine(ma[i]);
            }

            double[] md = new double[5] { 12.2, 14.4, 16.0, 12.4,19.9 };

            Console.WriteLine();
            Console.WriteLine(" md list =>");
            for (int i = 0; i < md.Length; i++)
            {
                Console.WriteLine(md[i]);
            }

        }
    }
}
