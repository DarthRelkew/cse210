using System;
using System.IO.Compression;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    int x;
    x = 4;
    Console.WriteLine($"What is the magic number {x}");
    Console.Write("What is the your guess? ");
    string guess = Console.ReadLine();
    int y = int.Parse(guess); 
    
     if(x == y)
     {
        Console.WriteLine("You guessed the magic number!");
     }
     if (x > y)
     {
        Console.WriteLine("Higher");
     }
     if (x < y)
     {
        Console.WriteLine("Lower");
     }
// Second part of the code below
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1,101);
    int guess_1 = -1;
    Console.WriteLine($"What is the magic number? {number}");
    while (guess_1 != number)
    {
        Console.WriteLine("What is your guess? ");
        string guess_3 = Console.ReadLine();
        if(int.TryParse(guess_3, out int z))
        {
            if (z == number)
            {
                Console.WriteLine("You guessed the magic number!");
                break;
            }
            if (number < z)
            {
                Console.WriteLine("Lower");
            }
            if (number > z)
            {
                Console.WriteLine("Higher");
            }
        }



    }
    
    }
}
