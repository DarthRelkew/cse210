using System.Diagnostics;

public class Breathing : Activity
{
    public Breathing(int duration) : base("Breathing", "You will begin to relax by letting us walk you through this activity and breathing in and out.", duration) {}

    protected void ShowPrompt(int index)
    {
        if (index % 2 == 1)
            Console.WriteLine("Breathe in...");
        else
            Console.WriteLine("Breathe out...");
        ShowAnimation();
        Thread.Sleep(1000);
    }
}