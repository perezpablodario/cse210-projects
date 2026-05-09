using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int totalSquare = SquareNumber(userNumber);
        DisplayResult(userName, totalSquare);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int number)
    {
        int squuareNumber = number * number;
        return squuareNumber;
    }

    static void DisplayResult(string user, int square)
    {
        Console.WriteLine($"{user}, the square of your number is {square}");
    }
}