class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Relaxation Activities Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose and Activity (1-4): ");

            string choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3")
            {
                Console.Write("Enter the duation of the activity in seconds: ");
                if (int.TryParse(Console.ReadLine(), out int duration) && duration >0)
                {
                    if (choice == "1")
                    {
                        Breathing breathing = new Breathing(duration);
                        breathing.ActivityStart();
                    }
                    else if (choice == "2")
                    {
                        Reflecting reflection = new Reflecting(duration);
                        reflection.ActivityStart();
                    }
                    else
                    {
                        Listening listening = new Listening(duration);
                        List<string> items = listening.ListItems();
                        Console.WriteLine($"You made a list of these items: {items.Count}");
                        listening.ActivityStart();
                    }
                }
                else
                {
                    Console.WriteLine("That duratin will not work, Please enter a positive number.");
                    Thread.Sleep(2000);
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thanks for playing and I hope you feel better soon.");
                break;
            }
            else
            {
                Console.WriteLine("Please choose an activity between 1-4.");
                Thread.Sleep(2000);
            }
        }
    }
}