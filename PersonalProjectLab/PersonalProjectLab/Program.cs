using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                Console.WriteLine("Enter 1 to calculate feet to meters, enter 2 to calculate miles to kilometers");
                string conversion = Console.ReadLine();
                if (conversion == "1")
                {
                    string input = "";
                    int feet = 0;

                    Console.WriteLine("Enter number of feet to convert");
                    input = Console.ReadLine();
                    feet = int.Parse(input);

                    distanceconversion ans = new distanceconversion();

                    double meters = ans.calculatemeters(feet);

                    Console.WriteLine("Number of meters:" + ans);

                }
                else if (conversion == "2")
                {
                    string input = "";
                    int miles = 0;

                    Console.WriteLine("Enter the number of miles to convert");
                    input = Console.ReadLine();
                    miles = int.Parse(input);

                    distanceconversion ans = new distanceconversion();

                    double kilometers = ans.calculatekilometers(miles);

                    Console.WriteLine("Number of Kilometers:" + ans);

                }


                    Console.WriteLine("Enter 1 to calculate another conversion, enter 2 to quit");
                string anotherConversion = Console.ReadLine();

                if (anotherConversion == "2")
                {
                    shouldContinue = false;
                }
            }

            Console.WriteLine("Thank you for using my program!");

        }

    }

    }
