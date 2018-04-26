using System;

namespace Lab4_TableofPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int Num1;

            //Introduction to user
            Console.WriteLine("Greetings! Learn your Squares and Cubes!");
            string input = "";

            //WHILE Loop begins before the request for information from user
            do
            {
                //Request of information from user
                Console.WriteLine("Please enter an integer: ");
                Num1 = Convert.ToInt32(Console.ReadLine());

                //Formatting
                Console.WriteLine("NUMBER\t\tSQUARED\t\tCUBED");
                Console.WriteLine("\n======\t\t=======\t\t=====");

                //Calculations for the FOR Loop
                //i is input by the user
                //i is declared an integer
                //for(initialization; Boolean Expression, Update)
                for (int i = 1; i <= Num1; i++)
                {
                    Console.WriteLine("\n" + i + "\t\t" + (i * i) + "\t\t" + (i * i * i));
                }
                
                do
                {
                    //Ask user if they would like to continue
                    Console.WriteLine("\n\nWould you like to continue? Please enter Y or N");
                    //Converts the user's input to Uppercase
                    input = (Console.ReadLine().ToUpper());

                    //Based on the user's response, the program will continue or exit.

                    if (input != "Y" && (input != "N"))
                    {
                        Console.WriteLine("Invalid response. Please enter Y or No.");
                    }
                } while (input != "Y" && input != "N");

            } while (input == "Y");

            //Completes the WHILE Loop

            //Thank the user for participating
            Console.WriteLine("\nThank you for participating! Press enter to exit.");

            Console.ReadKey();
        }

    }
}
