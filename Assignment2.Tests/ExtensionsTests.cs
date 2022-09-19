namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_Given_HTTPS_Returns_True()
    {
        var uri = new Uri("https://www.google.com/");

        bool b = Extensions.IsSecure(uri);
        
        Assert.True(b);
    }
    [Fact]
    public void IsSecure_Given_FalseURL_Returns_False()
    {
        var uri = new Uri("http://www.google.com/");

        bool b = Extensions.IsSecure(uri);
        
        Assert.False(b);
    }

    [Fact]
    public void WordCount_Returns_Expected()
    {
        var s = "This is a 000 -+ test";

        var i = Extensions.WordCount(s);
        
        Assert.Equal(4,i);

    }
}
