using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "why was this experience meaningful to you?",
        "Have you ever dane anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on time in your life when you have show strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following question as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {
            DsiplayQuestions();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int idex = random.Next(_prompts.Count);
        return _prompts[idex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        String prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"*** {prompt} ***");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DsiplayQuestions()
    {
        string question = GetRandomQuestion();

        Console.WriteLine($"{question}");
        ShowSpinner(6);
        Console.WriteLine();
    }
}