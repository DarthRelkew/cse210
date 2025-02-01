using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
      Movie favoriteMovie = new Movie();
      favoriteMovie._title = "Star Wars"; //the dot allows you to access the the box in the class
      favoriteMovie._year = 1977;
      favoriteMovie._runtime = 150;
      favoriteMovie._rating = "PG";

      Movie otherFavoriteMovie = new Movie();
      otherFavoriteMovie._title = "Avatar";
      otherFavoriteMovie._year = 2009;
      otherFavoriteMovie._rating = "PG-13";
      otherFavoriteMovie._runtime = 162;

      favoriteMovie.Display();

      DisplayMovie(favoriteMovie);
      DisplayMovie(otherFavoriteMovie);
    }

    static void DisplayMovie(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }
}