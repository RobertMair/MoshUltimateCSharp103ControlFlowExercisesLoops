using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    
    // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
    // If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program
    // is behaving correctly, you can display the secret number on the console first.)

    class Program
    {
        
        static void Main(string[] args)
        {
            int min = 1;
            int max = 10;
            int guesses = 4;
            Random random = new Random();
            string outcome = "";
            bool loop = true;

            while (loop)
            {
                int number = random.Next(min, max);

                int count = 0;
                Console.WriteLine(number);
                Console.CursorVisible = false;

                while(count < guesses )
                {
                    Console.Write("\nEnter guess number {0} of random number between {1} and {2} => ", count+1, min, max);
                    var input = Console.ReadLine();
                    int result;

                    var success = Int32.TryParse(input, out result);
                    if (success && result >= min && result <= max)
                    {
                        Console.Write(" > Valid");
                        if (outcome != "You won") outcome = result == number ? "You won" : "You lost";
                        count++;
                    }
                    else
                    {
                        Console.Write(" > Invalid, try again..");
                    }
                }

                Console.WriteLine("\nThe result of your guesses: " + outcome);
                
                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;
            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();

        }
    }
}