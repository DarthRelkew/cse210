using System.Diagnostics;

public class Reflecting : Activity
{
    private string[] _reflectionPrompts = new string[]
    {
        "Think of a time when you overcame a challenge—how did you approach it, and what did you learn about yourself?",
        "Think of a time when you felt truly inspired—what sparked that feeling, and how did it shape your actions?",
        "Think of a time when you made a difficult decision—what factors influenced your choice, and how do you feel about it now?",
        "Think of a time when you helped someone—what did you do, and how did it impact both you and them?",
        "Think of a time when you experienced failure—how did you handle it, and what steps did you take to move forward?",
    };

    public Reflecting(int duration) : base("Reflection", "In this activity you will take the time to reflect on different times in your life.", duration) {}

    protected override void ShowPrompt(int index)
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectionPrompts.Length);
        Console.WriteLine(_reflectionPrompts[randomIndex]);
        ShowAnimation();
        Thread.Sleep(1000);
    }
}