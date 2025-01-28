using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menus:");
        Console.WriteLine("1. Add new job: ");
        Console.WriteLine("2. Display Reume: ");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Resume theResume 
        bool keepRunning = true;

        while(keepRunning)
        {
            DisplayMenu();

            Console.WriteLine("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Add a new job
                Console.Write("What is the name of the company?");
                string company = Console.ReadLine();

                Console.Write("What is the position? ");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
            }
            else if (choice == "2")
            {
                // Display Resume
            }
            else if (choice == "3")
            {
                // Quit
                keepRunning = false;
            }
            else
            {
                //unexpected input
                Console.WriteLine("Sorry, that is not valid. Please try again.");
            }
        }
    }
}