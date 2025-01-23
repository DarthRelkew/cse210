public class Job
{

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_company}");
    }
}
public class Resume
{
    public string _name;
    public string _jobs;

}