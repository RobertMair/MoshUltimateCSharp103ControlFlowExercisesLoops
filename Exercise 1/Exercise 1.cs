using System;

namespace Exercise_1
{

    // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
    // Display the count on the console.
    class Program
    {
        static void Main(string[] args)
        {

            bool loop = true;
            while (loop)
            {
                int count = 0;
                for (int i = 1; i < 100; i++)
                {
                    if (i % 3 == 0) count++;
                }

                Console.WriteLine("Total numbers between 1 and 100 divisible by 3 with no remainder is: " + count);

                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;
            }

            Console.WriteLine("\nPress any key to exit program..");
        Console.ReadKey();
        }
    }
}
