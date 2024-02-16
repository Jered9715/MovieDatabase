using ConsoleApp1;

//create list
List<Movie> movieList = new List<Movie>();

//establish 10 movies in list
movieList.Add(new Movie("Treasure Planet", "animated"));
movieList.Add(new Movie("Emperors New Groove", "animated"));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));
movieList.Add(new Movie("", ""));

Console.WriteLine(DisplayMovies("animated"));

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("");
Console.WriteLine($"There are {movieList.Count} in this list");
Console.WriteLine("Youll be able search our movie library by entering a category of movie.");
string userAnswer = "";
int numberOfUses = 0;
//create While loop
while (true)
{
    if (numberOfUses == 0)
    {
        Console.WriteLine("Before we start would you like to see a" +
            " list of the movie categories? (y/n): ");
        userAnswer = Console.ReadLine();
        if (userAnswer.ToLower().Trim() == "y")
        {
            DisplayCategories();
        }
    }
    else 
    {
        Console.WriteLine("Would you like to see the categories again? (y/n): ");
        userAnswer = Console.ReadLine();
        if (userAnswer.ToLower().Trim() == "y")
        {
            DisplayCategories();
        }
    }

    Console.Write("What category are you interested in?: ");
    string userInput = Console.ReadLine();
    if(userInput.ToLower().Trim() != )




    //Loop break out
    Console.Write("Continue? (y/n): ");
    userAnswer = Console.ReadLine();
    if (userAnswer.ToLower().Trim() != "y")
    { break; }
    numberOfUses++;
}










//Method to display Categories
void DisplayCategories()
{
    foreach (Movie movie in movieList)
    {
        Console.WriteLine(movie.Category);
    }
}

//Method for valid category

//Method to display movies
//need to split in narrowing the category and displaying the category
void DisplayMovies(string category)
{
    var chosenCategory = movieList.FindAll(x => x.Category == category);

    foreach (Movie movie in chosenCategory)
    {
        Console.WriteLine(movie.Title);
    }

}