using System;

class Program
{
    static void Main(string[] args)
    {

        string guess = "no";
        string play = "yes";
        int track = 0;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        while (play == "yes")
        {
            guess = "no";
            track = 0;
            while (guess == "no")
            {
                track++;

                Console.Write("What is your guess? ");
                int guessNumber = int.Parse(Console.ReadLine());

                if (number == guessNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {track} guesses!!!");
                    guess = "yes";
                }
                else if (number > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.Write("Do you want to play again? (yes / no) ");
            play = Console.ReadLine();
        }

    }
}