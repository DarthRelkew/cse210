using System.Net;

public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;

    public Book(string newTitle, string newAuthor)
    {
        _title = newTitle;
        _author = newAuthor;
        _checkOutDate = "";
    }
    public void CheckOut()
    {
        _checkOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }
    public bool IsCheckedOut()
    {
        bool isCheckedOut;

        if (_checkOutDate == "")
        {
            isCheckedOut = false;
        }
        else
        {
            isCheckedOut = true;
        }

        return isCheckedOut;
    }
    public void Display()
    {

        Console.WriteLine($"{_title} by {_author} checked out: {_checkOutDate} ");

    }

}