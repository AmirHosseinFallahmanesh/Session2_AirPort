using System;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 5, 7, 4, 2, 3, 9 };
            Array.Sort(myArray);
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]+"," );
               
            }
            Console.WriteLine();
            int index=Array.BinarySearch(myArray, 5);
            Console.WriteLine(index);

        }
    }
}
