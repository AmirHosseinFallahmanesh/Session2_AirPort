using System;

namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            //long int  -  string int  - double int

            //implicity cast
            int i1 = 12;
            double i2 = i1;


            //explicity cast

            double e1 = 12.14;
            int e2 =(int)e1;
            float f = (float)1325.25;


            //var  object  dynamic
            object obj1 = 12;  //int
            obj1 = "test"; //string
            obj1 = 12.5; //double


            var v1 = 12.5;

            dynamic d1 = "test";
            d1 = 12;
            
           

        }
    }
}
