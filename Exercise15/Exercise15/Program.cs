using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {

                Console.WriteLine("Please enter a number");
                Console.WriteLine("-------------------");

                double number = double.Parse(Console.ReadLine());

                int counter;
                double maxValue = number;

                //Cubes & Prints
                for (counter = 1; counter <= maxValue; counter++)
                {
                    int cubed = counter * counter * counter;
                    Console.WriteLine("{0}   {1}", counter, cubed);
                }

                //Continue Loop
                while (true)
                {
                    Console.WriteLine($"Would you like to continue? yes/no");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        goOn = true;
                        break;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                    }
                }

            }
        }
    }
}
    

