using System;

namespace Exercise_3
{

    // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
    // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                Console.Write("\nEnter a number to calculate it's factorial => ");
                var input = Console.ReadLine();
                int result;

                var success = Int32.TryParse(input, out result);
                if (success)
                {
                    Console.Write(" > Valid");
                    int factorial = FactorialRecursion(result);
                    Console.WriteLine("\nThe factorial result of {0} is {1}", result, factorial);

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
        
        public static int FactorialRecursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * FactorialRecursion(number - 1);
        }

    }
}