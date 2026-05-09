using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int cont = 1;
        int sum = 0;
        float average = 0;
        int maxNumber = 0;

        List<int> numbers = new List<int>();

        while (cont != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            int addNumber = int.Parse(Console.ReadLine());
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
            else
            {
                cont = 0;
            }
        }

        foreach (int num in numbers)
        {
            sum = sum + num;
        }

        float totalList = numbers.Count;
        average = ((float)sum) / totalList;

        foreach (int max in numbers)
        {
            if (maxNumber < max)
            {
                maxNumber = max;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}