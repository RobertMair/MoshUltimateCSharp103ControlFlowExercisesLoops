using System;
using System.Linq;

namespace Exercise_5
{

    // Write a program and ask the user to enter a series of numbers separated by comma.
    // Find the maximum of the numbers and display it on the console. For example, if the
    // user enters “5, 3, 8, 1, 4", the program should display 8.

    class Program
    {
        
        static void Main(string[] args)
        {

            int total = 0;
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                Console.Write("\nEnter a series of numbers separated by a comma (',') => ");
                var input = Console.ReadLine();
                int result;

                var numbers = input
                    .Split(',')
                    .Where(x => int.TryParse(x, out _))
                    .Select(int.Parse)
                    .ToList();

                Console.Write("Valid numbers entered are: ");
                foreach (int i in numbers)
                {
                    Console.Write(i + "  ");
                }
                
                Console.WriteLine("\nThe maximum number is: " + numbers.Max());

                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();

        }
    }
}
