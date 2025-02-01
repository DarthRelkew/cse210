using System;
<<<<<<< HEAD
using System.Numerics;

=======
using System.Threading.Tasks.Dataflow;
using Microsoft.Win32.SafeHandles;
>>>>>>> e3867d9902c1644aec366c254aaf1bd25ed84363

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
<<<<<<< HEAD
        Job job = new Job();
        job._company = "BYU Idaho";
        job._jobTitle = "Student";
        job._startYear = 2022;
        job._endYear = 2027;

        // job.Display();

        Job job1 = new Job();
        job1._company = "LegoLand California";
        job1._jobTitle = "Warehouse Associate";
        job1._startYear = 2018;
        job1._endYear = 2019;

        // job1.Display();

        DisplayJob(job);
        DisplayJob(job1);

        Resume myResume = new Resume();
        myResume._name = "Chance Edwards";
        myResume._jobs = "Student (BYU Idaho) 2022-2027 \n Warehouse Associate (LegoLand California) 2018-2019";

        DisplayResume(myResume);

    }
    static void DisplayJob(Job aJob)
    {
        Console.WriteLine($"{aJob._jobTitle} ({aJob._company}) {aJob._startYear}-{aJob._endYear}");
    }
    static void DisplayResume(Resume aResume)
    {
        Console.WriteLine($"\n Name: {aResume._name} \n Jobs: \n {aResume._jobs}");
=======
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
>>>>>>> e3867d9902c1644aec366c254aaf1bd25ed84363
    }
}