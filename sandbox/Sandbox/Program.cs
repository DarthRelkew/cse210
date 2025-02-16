using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
      Book b1 = new Book("Jurassic Park","Micheal Crichton");
      Book b2 = new Book("Tom Sawyer","Mark Twain");
      

      b1.CheckOut();

      b1.Display();
      b2.Display();

    }
}