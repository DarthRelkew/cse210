using System;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
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
    }
}