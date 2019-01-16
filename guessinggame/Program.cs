using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess);

            // if they guess 7
            if (userGuess.Equals("7"))
            {
                // then they win
                Console.WriteLine("You win!");
            }
            else if (userGuess.Equals("0"))
            { 
                Console.WriteLine("Please follow all instructions");


        } else
            {
                // otherwise they lose
                Console.WriteLine("You Lost");
            }

            // then they win
            // otherwise they lose

        }
    }
}
