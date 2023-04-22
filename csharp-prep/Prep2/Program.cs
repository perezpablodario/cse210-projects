using System;

class Program
{
    static void Main(string[] args)
    {
        // Detrmines the letter grade for a course according to the following scale: A >= 90, B >= 80, C >= 70, D >= 60 and F < 60
        
        // Varialbe to store the grade entered for the user.
        int grade = 0;

        // Variable to store de Letter
        string letter = "";

        // Variable to store the sign and variable to store de last digit
        string sign = "";
        int digit = 0;

        // Ask the user for the grade.
        Console.Write("Enter the grade porcentaje: ");
        grade = int.Parse(Console.ReadLine());

        // Determine the sign of the grade
        Math.DivRem(grade, 10, out digit);
        if (digit >= 7)
            sign = "+";
        else if (digit < 3)
            sign = "-";
        else
            sign = "";

        // Series of if, else if and else to determined the letter grade.
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        if (letter == "F" || letter == "D")
        {
            Console.WriteLine($"Your letter grade is {letter} {sign}");
            Console.WriteLine("You can do better. Try again.");
        }       

        else
        {
            Console.WriteLine($"Your letter grade is {letter} {sign}");
            Console.WriteLine("Congratulatios, You pass the course.");
        }
    }
}