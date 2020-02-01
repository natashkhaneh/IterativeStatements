using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter an integer value
            Console.WriteLine("Please enter an integer value between 1 and 100");

            try
            {
                // Gathers user's entered input
                string input = Console.ReadLine();

                // Parses user's entered input to an integer
                int input_value = int.Parse(input);

                //Executes a For loop if the user input is between 0 and 100
                if ((input_value > 0) && (input_value <= 100))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + input_value.ToString() + " times.");

                    // For loop
                    for (int i = 0; i < input_value; i++)
                    {
                        int j = i + 1;
                        Console.WriteLine("You have entered " + input_value.ToString() +". The current integer value in the loop is " + j.ToString() + ".");
                    }

                    //Prompts user to exit the program.
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);

                }
            }
            // End of try

            catch
            {
                // Displays a message if user input is invalid.
                Console.WriteLine("Please enter a valid integer value and running the program again.");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }
            //End of catch
        }
    }
}
