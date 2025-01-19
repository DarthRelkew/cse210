using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    { 
        //list built here
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter in numbers(both positive and negative numbers are good) to the list, type 0 when done.");
       // loop to keep iterating and adding to the list
        while (true) 
        {
            Console.Write("Enter a number: ");
            string user_input = Console.ReadLine();
            int x = int.Parse(user_input);
            numbers.Add(x);

             int LastNumbers = numbers[numbers.Count -1];

            if (LastNumbers == 0)
            {
                break;
            }
            
        }
        // list sorting
        int count = numbers.Count;
        int sum = numbers.Sum();
        int large = numbers.Max();
        Console.WriteLine($"The sum of the list is: {sum}.");
        Console.WriteLine($"The Average of the list is: {sum / count}. ");
        Console.WriteLine($"The largest number is: {large}.");

    }
}