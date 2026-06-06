using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Star breathing activity");
            Console.WriteLine("   2. Star reflecting activity");
            Console.WriteLine("   3. Star listing activity");
            Console.WriteLine("   4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Select one of the choices of the menu");
                Thread.Sleep(3000);
            }
        }
    }
}