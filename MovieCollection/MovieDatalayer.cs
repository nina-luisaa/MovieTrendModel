using MovieTrend;

namespace MovieCollection
{
    public class MovieDatalayer
    {
        public void MyMovies()
        {
            List<Movie> movie = new List<Movie>();

            Console.WriteLine("MovieTrends in Philippines");
            Console.WriteLine();

            Movie top1Movie = new Movie();

            top1Movie.title = "Knights of the Zodiac";
            top1Movie.director = "Tomek Baginski";
            top1Movie.genre = "Fantasy";
            top1Movie.releaseDate = new DateTime(2023, 04, 27);
            top1Movie.rate = "9/10";


            Movie top2Movie = new Movie
            {
                title = "Sisu",
                director = "Jalmari Helander",
                genre = "Action",
                releaseDate = new DateTime(2023, 01, 27),
                rate = "10/10",
            };


            List<Movie> trendingMovies = new List<Movie>();
            trendingMovies.Add(top1Movie);
            trendingMovies.Add(top2Movie);

            DisplayMovies(trendingMovies);

        }

        static void DisplayMovies(List<Movie> allmovies)
        {
            foreach (var mov in allmovies)
            {
                Console.WriteLine($"Movie: {mov.title}");
                Console.WriteLine($"Director: {mov.director}");
                Console.WriteLine($"Genre: {mov.genre}");
                Console.WriteLine($"Release Date: {mov.releaseDate}");
                Console.WriteLine($"Rate: {mov.rate}");
                Console.WriteLine();
            }
        }
    }
}

   