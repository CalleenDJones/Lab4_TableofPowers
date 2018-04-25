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

            //WHILE Loop begins before the request for information from user
            while (true)
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
                    Console.WriteLine("\n\n" + i + "\t\t" + (i * i) + "\t\t" + (i * i * i));
                }


                //Ask user if they would like to continue
                Console.WriteLine("\n\nWould you like to continue? Please enter Y or N");
                //Converts the user's input to Uppercase
                string input = (Console.ReadLine().ToUpper());
                
                //Based on the user's response, the program will continue or exit.
                //Completes the WHILE Loop
                if (input == "Y")
                {
                    continue;
                }
                
                else
                {
                    break;
                }
            }
            //Thank user for participating
            Console.WriteLine("\nThank you for participating! Press enter to exit.");
            Console.ReadKey();

        }






           
    }
}
