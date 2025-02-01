using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Text { get; set; }

    public Entry(DateTime date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - Prompt: {Prompt} - Entry: {Text}";
    }
}

public class Journal
{
    private List<Entry> entries;
    private List<string> prompts;
    private Random random;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string> 
        {
            "What are you grateful for today?",
            "Describe a memorable event this week.",
            "What are your goals for the future?",
            "Write about a challenge you faced and how you overcame it."
        };
        random = new Random();
    }

    public void AddEntry(string text)
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Entry entry = new Entry(DateTime.Now, prompt, text);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Text}");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string text = parts[2];
                Entry entry = new Entry(date, prompt, text);
                entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}


