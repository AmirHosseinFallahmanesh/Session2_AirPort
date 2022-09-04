using System;

namespace Part1_GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)Easy"); //7  1 100
                Console.WriteLine("2)Noraml");//5 1 1000
                Console.WriteLine("3)Hard");//3   1 10000
                string select = Console.ReadLine();
                int maxLimit = 0;
                int lowerBound = 0;
                int upperBound = 0;
                switch (select)
                {
                    case "1":
                        maxLimit = 10;
                        lowerBound = 1;
                        upperBound = 100;
                        break;
                    case "2":
                        maxLimit = 7;
                        lowerBound = 1;
                        upperBound = 1000;
                        break;
                    case "3":
                        maxLimit = 5;
                        lowerBound = 1;
                        upperBound = 10000;
                        break;
                    default:

                        break;
                }
                Random randomGenerator = new Random();
                int guess = randomGenerator.Next(lowerBound, upperBound);
                int counter = 0;
                while (true)
                {
                    if (counter == maxLimit)
                    {
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Enter Number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number > guess)
                    {
                        Console.WriteLine("Enter Lower Number");

                    }
                    else if (number < guess)
                    {
                        Console.WriteLine("Enter Higher Number");
                    }
                    else
                    {
                        Console.WriteLine("You Win ...");
                        break;
                    }
                    counter++;
                }
            }

        }
    }
}
