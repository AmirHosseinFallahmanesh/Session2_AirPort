using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[4] { "ali", "reza", "mina", "sina" };


            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)Edit Name");
                Console.WriteLine("2)Print Names");
                Console.WriteLine("3)Exit");
                string select = Console.ReadLine();
                switch (select)
                {
    
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter Search");
                        string search = Console.ReadLine();

                        int index = -1;
                        for (int i = 0; i < data.Length; i++)
                        {
                            if (search == data[i])
                            {
                                index = i;
                                break;
                            }

                        }
                        if (index != -1)
                        {
                            Console.WriteLine("Enter New Name");
                            data[index] = Console.ReadLine();
                            Console.WriteLine("Edit Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Name Not Found");
                            
                        }
                        Console.ReadKey();

                        break;

                    case "2":
                        Console.Clear();
                        for (int i = 0; i < data.Length; i++)
                        {
                            Console.WriteLine(data[i]);
                        }
                        Console.ReadKey();
                        break;


                    case "3":

                        return;


                    default:
                        Console.WriteLine("invalid input");
                        Console.ReadKey();
                        break;
                }


            }
            


        }
    }
}
