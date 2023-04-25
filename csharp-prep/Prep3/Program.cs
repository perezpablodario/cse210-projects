using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable to store the magic number
        int magicNumber = 0;

        // Variable to store the guesses
        int guessesAttempts = 1;

        // Variable to store the guess number
        int guessNumber = 0;

        // Variable to use for the while loop in the continue playing part of the program
        string continueGame = "yes";

        // Variale to use for the while loop in the guess part of the program
        Boolean guessContinue = false;

        // While loop to ask the user for continue the game
        while (continueGame == "yes")
        {
            // Crate the instance of the random class
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 20);
            guessesAttempts = 1;
            guessContinue = false;
            
            // While to continue palying the game until the user guess
            while(guessContinue == false)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                // Use a if statement to determine if the user needs to guess higher or lower and show a mensagge when the user guess.
                if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                    guessesAttempts += 1;
                }
                else if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                    guessesAttempts += 1;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You attempts {guessesAttempts} guesses");
                    guessContinue = true;
                }
            }
            Console.Write("Do you want to play again? [yes / no] ");
            continueGame = Console.ReadLine();    
        }

        // Show the menssage Game Over when the user select no
        Console.WriteLine("GAME OVER");
    }
}