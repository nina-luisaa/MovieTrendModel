using MovieCollection;
using MovieTrend;

namespace MovieTrends
{
    public class BL
    {
        static public bool LoginUser(string un, string pw)
        {
            string registeredUsername = "Astillero";
            string registeredPassword = "Nina";


            return un == registeredUsername && pw == registeredPassword;
        }
    }
}
