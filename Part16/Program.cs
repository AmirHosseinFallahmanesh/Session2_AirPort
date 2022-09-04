using System;
//return type methodName(datatype1 p1,datatype2 p2,...)
namespace Part16
{
    class Program
    {
        static void Main(string[] args)
        {
           int result= sum(10, 26);

            Console.WriteLine("result "+result);
        }
        static int sum(int a,int b)
        {
            Console.WriteLine("method call");
            return a + b;
        }
    }
}
