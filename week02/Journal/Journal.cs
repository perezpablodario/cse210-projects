using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _writingText = new List<Entry>();
    public Prompts prompts = new Prompts();


    public void AddWriting(Entry entry)
    {
        entry._prompt = prompts.RandomPromt();
        Console.WriteLine(entry._prompt);

        entry._writing = Console.ReadLine();

        DateTime date = DateTime.Now;
        entry._date = date.ToString();

        _writingText.Add(entry);
    }

    public void ReviewJournal()
    {
        foreach (Entry entry in _writingText)
        {
            entry.Display();
        }
    }

    public void SaveWriting(string File)
    {
        using (StreamWriter writer = new StreamWriter(File))
        {
            foreach (Entry entry in _writingText)
            {
                writer.WriteLine($"{entry._date} ~ {entry._prompt} ~ {entry._writing}");
            }
        }
    }

    public void LoadWriting(string File)
    {
        string[] lines = System.IO.File.ReadAllLines(File);

        _writingText.Clear();

        foreach (string line in lines)
        {

            string[] parts = line.Split("~");

            Entry entryCargada = new Entry();
            entryCargada._date = parts[0];
            entryCargada._prompt = parts[1];
            entryCargada._writing = parts[2];

            _writingText.Add(entryCargada);

        }
    }
}