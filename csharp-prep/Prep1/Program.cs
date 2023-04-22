using System;

class Program
{
    static void Main(string[] args)
    {
        // variables to store the first and last name of the user
        string first_name = "";
        string last_name = "";

        // Ask for the first name of the user
        Console.Write("What is your first name? ");
        first_name = Console.ReadLine();

        // Ask for the last name of the user
        Console.Write("What is your last name? ");
        last_name = Console.ReadLine();

        // Show the name 
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}