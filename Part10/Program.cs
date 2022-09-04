using System;

namespace Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(12,"test",true);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);

            Array array = Array.CreateInstance(typeof(bool), 10);
            
           
         

        }
    }
}
