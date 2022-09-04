using System;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Shallow Copy********************");
            int[] ma = new int[] { 10, 20, 30 };
            int[] mb = ma;

            mb[1] = 2000;

            Console.WriteLine("ma => ");
            for (int i = 0; i < ma.Length; i++)
            {
                Console.WriteLine(ma[i]);
            }


            Console.WriteLine("mb => ");
            for (int i = 0; i < mb.Length; i++)
            {
                Console.WriteLine(mb[i]);
            }

            Console.WriteLine("***************Deep Copy********************");
            int[] mc = new int[] { 10, 20, 30 };
            //int[] md =(int[]) mc.Clone() ;
            int[] md =mc.Clone() as int[] ;

            md[1] = 2000;

            Console.WriteLine("mc => ");
            for (int i = 0; i < mc.Length; i++)
            {
                Console.WriteLine(mc[i]);
            }


            Console.WriteLine("md => ");
            for (int i = 0; i < md.Length; i++)
            {
                Console.WriteLine(md[i]);
            }

        }
    }
}
