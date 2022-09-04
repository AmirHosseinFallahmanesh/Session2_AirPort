using System;

namespace Part17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4] { "amir", "reza", "sina", "mina" };
            bool result=find(names, "amir");
            int index=findIndex(names, "amir");
        }

        static bool find(string[] data,string search)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i]==search)
                {
                    return true;
                }
            }

            return false;
        }

        static int findIndex(string[] data, string search)
        {
            int index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == search)
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
