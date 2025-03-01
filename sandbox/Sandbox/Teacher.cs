public class Teacher : Staff
{
    public int _classNumber;
    public string _lastName;
    public string _gender;

    public Teacher(string _lastName, string _gender,int _classNumber)
    {
        _classNumber = classNumber;
        _lastName = _lastName;
        _gender = _gender;
    }
    
    public void Display()
    {
        Console.WriteLine($"Hello Students, I am {_gender} {_lastName}. I teach in room {_classNumber}");
    }
}