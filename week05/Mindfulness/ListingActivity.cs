using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many thing as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();

        Console.WriteLine("You may begin in: ");
        ShowCountDown(6);
        Console.WriteLine();

        List<string> itemResponses = GetListFromUser();

        Console.WriteLine($"You listed {itemResponses.Count} responses!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine("List as many items as you can for the following prompt:");
        Console.WriteLine($"*** {_prompts[index]} ***");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("=> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }

        return responses;
    }
}