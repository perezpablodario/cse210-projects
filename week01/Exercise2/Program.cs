using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign = "";
        int lastDigit = 0;

        Console.Write("Plase, enter the grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        lastDigit = grade % 10;


        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!!! you have passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. You can do better.");
        }
    }
}