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
        var strings = s.Split(" ");
        foreach (var stringPart in strings)
        {
            if(stringPart.Contains)
        } 
    }
}
