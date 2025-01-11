using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);

        string letter = "";
        
        if(x >= 90 && x <= 100)
        {
            letter = "A";
        }
        if (x >= 80 && x <=89)
        {
            letter = "B";
        }
        if (x >= 70 && x <=79)
        {
            letter = "C";
        }
        if (x >= 60 && x <= 69)
        {
            letter = "D";
        }
        if (x < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade in the class is {letter}");
        
        if (x >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
    }
}