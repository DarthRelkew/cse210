using System;
using System.IO;

class Program
{
    public class Journal
    {

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}
string fileName = "Journal.txt";

using (StreamWriter outputFile new StreamWriter(fileName))
{

}