using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Variable to use in the while loop.
        int continueNumber = 1;
        // Variable to store the numbers that enter the user.
        int number = 0;
        // Variable to store the size of the list.
        int lenList = 0;
        // variable to store the average.
        float averageList = 0;
        int larges = 0;
        // Variable to store the sum od the numbers of the list.
        int sumNumber = 0;
        // Variable list to store the numbers engered for the user.
        List<int> listNumbers = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (continueNumber != 0)
        {
            // Ask for the number   
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                listNumbers.Add(number);
                if (number > larges)
                {
                    larges = number;
                }
            }
            else
            {
                continueNumber = 0;
            }
        }

        // print the list
        foreach (int num in listNumbers)
        {
            sumNumber = sumNumber + num;
        }

        // Print the sum of thr list.
        Console.WriteLine($"The sum is: {sumNumber}");
        // Obtain the length of the lsit.
        lenList = listNumbers.Count;
        // Calculate the averqge.
        averageList = ((float)sumNumber) / lenList;
        // Print the Averqge and The largest number.
        Console.WriteLine($"The average is: {averageList}");
        Console.WriteLine($"The largest number is: {larges}");
    }
}