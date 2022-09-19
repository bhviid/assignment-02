using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri)
    {
        if (uri.ToString().StartsWith("https"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int WordCount(this string s)
    {
        int count;
        Regex r = new Regex("[a-zA-Z]+");
        count = r.Matches(s).Count;
        return count;
    }
}
