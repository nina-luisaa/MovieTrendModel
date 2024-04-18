using MovieCollection;
using MovieTrends;
static void Main(string[] args)
{
    string username;
    string password;

    Console.WriteLine("LOGIN");
    Console.WriteLine();


    Console.WriteLine("Username: ");
    username = Console.ReadLine();


    Console.WriteLine("Password: ");
    password = Console.ReadLine();

    bool result = BL.LoginUser(username, password);


    if (result)
    {
        Console.WriteLine("Successfull!");
        Console.WriteLine();

        MovieDatalayer movieDatalayer = new MovieDatalayer();

        movieDatalayer.MyMovies();
    }

    else
    {
        Console.WriteLine("There's an error! Try again.");
    }
}