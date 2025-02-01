public class Movie // imagine a class like a box
{
    public string _title; //this is essentially a box for the object/variable to be in
    public int _year;
    public int _runtime;
    public string _rating;

    public void Display()
    {
        Console.WriteLine(_title);
    }
}