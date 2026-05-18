using System;

class Program
{

    static void Main(string[] args)
    {

        int flaw = 1;
        int chose = 0;

        Journal journal = new Journal();

        while (flaw == 1)
        {
            Console.WriteLine("Please, select one of the following choice");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            string stringChose = Console.ReadLine();
            chose = int.Parse(stringChose);

            if (chose == 1)
            {
                Entry entry = new Entry();
                journal.AddWriting(entry);
            }

            else if (chose == 2)
            {
                journal.ReviewJournal();
            }

            else if (chose == 3)
            {
                Console.WriteLine("What is the File? ");
                string file = Console.ReadLine();
                journal.SaveWriting(file);
            }

            else if (chose == 4)
            {
                Console.WriteLine("What is the File");
                string file = Console.ReadLine();
                journal.LoadWriting(file);
            }

            else
            {
                flaw = 0;
            }
        }
    }
}