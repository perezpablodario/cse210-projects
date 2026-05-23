using System;

class Program
{
    static void Main(string[] args)
    {

        //Reference reference = new Reference("Jhon", 3, 16);
        //string text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Scripture memorized");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}