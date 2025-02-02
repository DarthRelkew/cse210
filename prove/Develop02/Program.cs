using System;
using System.IO;
using System.Collections.Generic;

public class Entry
{
    private List<string> journalEntries = new List<string>(); // Stores entries in memory

    public void GenerateJournalEntries()
    {
        Random random = new Random();
        string[] prompts = {
            "What are you grateful for today?",
            "Describe a memorable event this week.",
            "What are your goals for the future?",
            "Write about a challenge you faced and how you overcame it.",
            "What is a random act of kindness you did or experienced recently?",
            "If you could have a conversation with any historical figure, who would it be and why?",
            "Describe a place you have always wanted to visit.",
            "What is a skill you would like to learn and why?",
            "Reflect on a book or movie that had a significant impact on you.",
            "What are three things you love about yourself?",
            "If you could change one thing about the world, what would it be and why?",
            "Write about a person who has inspired you and how they influenced your life.",
            "Describe a perfect day in your life from start to finish.",
            "What are your favorite childhood memories?",
            "What are your top three priorities in life right now?"
        };

        int index = random.Next(prompts.Length);
        string selectedPrompt = prompts[index];

        Console.WriteLine(selectedPrompt);
        string response = Console.ReadLine();

        string entry = $"{DateTime.Now:yyyy/MM/dd} - {selectedPrompt} {response}";
        journalEntries.Add(entry); // Store entry in memory
        Console.WriteLine("Entry added to journal but not yet saved.");
    }

    public void DisplayJournal()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (string entry in journalEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No new entries to save.");
            return;
        }

        Console.Write("Enter file name to save: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (string entry in journalEntries)
            {
                outputFile.WriteLine(entry);
            }
        }

        Console.WriteLine($"Journal saved successfully to {fileName}!");
        journalEntries.Clear(); // Clear memory after saving
    }

    public void LoadJournal()
    {
        Console.Write("Enter file name to load: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            journalEntries.Clear(); // Clear current entries before loading new ones
            string[] loadedEntries = File.ReadAllLines(fileName);

            journalEntries.AddRange(loadedEntries);
            Console.WriteLine($"Loaded {loadedEntries.Length} entries from {fileName}.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

public class Journal
{
    public static void Main()
    {
        Entry entry = new Entry();

        while (true)
        {
            Console.Write("\nPlease select one of the following choices: \n" +
                "1. Write\n" +
                "2. Display\n" +
                "3. Load\n" +
                "4. Save\n" +
                "5. Quit\n" +
                "What would you like to choose? ");

            if (!int.TryParse(Console.ReadLine(), out int response))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            if (response == 1)
            {
                entry.GenerateJournalEntries();
            }
            else if (response == 2)
            {
                entry.DisplayJournal();
            }
            else if (response == 3)
            {
                entry.LoadJournal();
            }
            else if (response == 4)
            {
                entry.SaveJournal();
            }
            else if (response == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please select a valid option.");
            }
        }
    }
}
