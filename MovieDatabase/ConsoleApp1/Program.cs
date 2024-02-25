using ConsoleApp1;
using System;
using System.Linq;
using System.Reflection;


List<Movie> movieList = new List<Movie>();
movieList.Add(new Movie("Treasure Planet", "animated"));
movieList.Add(new Movie("Emperors New Groove", "animated"));
movieList.Add(new Movie("Fellowship of the Ring", "fantasy"));
movieList.Add(new Movie("Red Dawn", "thriller"));
movieList.Add(new Movie("Harry Potter and the Prisoner of Azkaban", "fantasy"));
movieList.Add(new Movie("The Mummy", "adventure"));
movieList.Add(new Movie("Pricess Bride", "comedy"));
movieList.Add(new Movie("The Mask", "comedy"));
movieList.Add(new Movie("The Prestige", "thriller"));
movieList.Add(new Movie("Tomb Raider", "adventure"));



Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("");
Console.WriteLine("Youll be able search our movie library by entering a category of movie.");
string userAnswer = "";


while (true)
{
    Console.Write("What category are you interested in?: ");
    string userInput = Console.ReadLine();
    bool validMovieCategory = movieList.Exists(x => x.Category == userInput.ToLower().Trim());
   

    List<Movie> moviesInCategory = movieList.Where(x => x.Category.Contains(userInput.ToLower().Trim())).ToList();
    if (validMovieCategory == true)
    {
        foreach (Movie title in moviesInCategory)
        {
            Console.WriteLine(title.Title);
        }
    }
    else
    {
    Console.WriteLine("Im sorry that is not a valid category.");
    }
    //Loop break out
    Console.Write("Continue? (y/n): ");
    userAnswer = Console.ReadLine();
    if (userAnswer.ToLower().Trim() != "y")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

}









