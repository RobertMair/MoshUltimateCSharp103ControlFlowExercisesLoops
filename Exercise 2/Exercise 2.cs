using System;

namespace Exercise_2
{
    // Write a program and continuously ask the user to enter a number or "ok" to exit.
    // Calculate the sum of all the previously entered numbers and display it on the console.

    class Program
    {

        static void Main(string[] args)
        {
            int total = 0;
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                Console.Write("\nEnter a number (or OK to sum all numbers) => ");
                var input = Console.ReadLine();
                int result;

                var success = Int32.TryParse(input, out result);
                if (success)
                {
                    Console.Write(" > Valid");
                    total += result;
                }
                else if (input != null && input.ToUpper() == "OK")
                {
                    Console.WriteLine("\nThe total all of all previously entered numbers is: " + total);
                    total = 0;

                    Console.WriteLine("\nPress any key to run again or X to exit => ");
                    char rerun = Console.ReadKey(true).KeyChar;
                    if (rerun == 'x' || rerun == 'X') loop = false;

                }
                else
                {
                    Console.Write(" > Invalid, try again..");
                }
                
            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();

        }
    }
}
