public class Video
{
    public string _title;
    public string _author;
    public int _length;
    
    public List<comment> comments = new List<comment>();

    public int CountComment()
    {
        return comments.Count;
    }

    public Video(string title, string author,int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void displayVideo()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_length);
        Console.WriteLine(CountComment());
        
        for (int counter = 0; counter < CountComment() ;counter ++)
        {
            Console.WriteLine(comments[counter]);
        }

    }

}