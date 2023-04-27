using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squarenumber = SquareNumber(userNumber);

        DisplayResult(userName, squarenumber);

        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

         static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your faborite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int squareNumber)
        {
            int square = squareNumber * squareNumber;
            return square; 
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}