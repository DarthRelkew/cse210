public class video
{
    public string _title;
    public string _author;
    public int _length;
    
    public List<comment> comments = new List<comment>();

    public int countComment()
    {
        return comments.count;
    }

    public video(string title, string author,int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public displayVideo()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_length);
        Console.WriteLine(countComment);
        
        for (int counter = 0; counter < countComment;counter ++)
        {
            Console.WriteLine(comments[counter]);
        }
    }

}