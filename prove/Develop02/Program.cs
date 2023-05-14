using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Variable to use in the while loop and used as a flag to end the loop when the user press 5.
        int _continue = 1;

        //I use the Class PrompList to add the prompt that will show in a menu to select what to do.
        PromptsList prompts1 = new PromptsList();
        prompts1._promptsList = "Who was the most interesting person I interacted with today?";
        PromptsList prompts2 = new PromptsList();
        prompts2._promptsList = "What was the best part of my day?";
        PromptsList prompts3 = new PromptsList();
        prompts3._promptsList = "How did I see the hand of the Lord in my life today?";
        PromptsList prompts4 = new PromptsList();
        prompts4._promptsList = "What was the strongest emotion I felt today?";
        PromptsList prompts5 = new PromptsList();
        prompts5._promptsList = "If I had one thing I could do over today, what would it be?";

        // Create the list variable to store the prompts.
        List<PromptsList> _promptsList = new List<PromptsList>();
        _promptsList.Add(prompts1);
        _promptsList.Add(prompts2);
        _promptsList.Add(prompts3);
        _promptsList.Add(prompts4);
        _promptsList.Add(prompts5);

        // Create a list with the class Journal which use to store the answers of the user.
        List<Journal> _journalList = new List<Journal>();

        while (_continue == 1)
        {
            string _choises = DisplayMenu();

            if (_choises == "1")
            {
                // Call the function WriteJournal to write the answer.
                WriteJournal(_journalList, _promptsList);
            }
            else if (_choises == "2")
            {
               // Call the function DispalyJournal to show the answers written in the journal. 
               DisplayJournal(_journalList);
            }

            else if (_choises == "3")
            {
                // Use the function ReadFromFile to load the file journal
                _journalList = ReadFromFile();
                // Read and show the answers of the journal
                List<Journal> JournalList = _journalList;
                foreach (Journal journal in _journalList)
                {
                    Console.WriteLine($"Date: {journal._date} - Prompt: {journal._prompt}");
                    Console.WriteLine(journal._answer);    
                }
            }

            else if (_choises == "4")
            {
                // Function to save the answers in the file journal
                SaveToFile(_journalList);
            }

            else if (_choises == "5")
            {
                // Put the variable in 0 to stop the loop while, when the user press 5.
                _continue = 0;
            }
        }
        
    }
    // Function to show and enter the choise of the user.
    static string DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choises: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string _choises = Console.ReadLine();
        return _choises;
    }

    // Function to show the Journal
    static void DisplayJournal(List<Journal> _journals)
    {
        foreach (Journal _journal in _journals)
                {
                    Console.WriteLine($"Date: {_journal._date} - Prompt: {_journal._prompt}");
                    Console.WriteLine(_journal._answer);
                }
    }

    // Function to show the prompt and write the answer of the user.
    static void WriteJournal(List<Journal> _journalList, List<PromptsList> _promptsList)
    {
        Random _random = new Random();
                int _index = _random.Next(0, 4);

                Journal _journal = new Journal();

                string _time = "";
                string _answer = "";

                DateTime theCurrentTime = DateTime.Now;
                _time = theCurrentTime.ToShortDateString();

                Console.WriteLine($"{_promptsList[_index]._promptsList}");
                _answer = Console.ReadLine();

                _journal._date = _time;
                _journal._prompt = ($"Prompt: {_promptsList[_index]._promptsList}");
                _journal._answer = _answer;

                _journalList.Add(_journal);
    }

    // Function to save the file
    public static void SaveToFile (List<Journal> _journalLists)
    {
        string filename = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal _journal in _journalLists)
            {
                outputFile.WriteLine($"{_journal._date}~~{_journal._prompt}~~{_journal._answer}");
            }
        }
    }

    public static List<Journal> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Journal> journal = new List<Journal>();
        string filename = "Journal.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Journal newJournal = new Journal();
            newJournal._date = parts[0];
            newJournal._prompt = parts[1];
            newJournal._answer = parts[2];

            journal.Add(newJournal);
        }

        return journal;
    }

}