namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void ReverseString_Should_Print_hello()
    {
        Action<string> ReverseString = s => 
        {
            foreach (var n in s.Reverse().ToList())
            {
                Console.Write(n);
            }
        };
        
        var sw = new StringWriter();
        Console.SetOut(sw);
       
        ReverseString("olleh");
   
        Assert.Equal("hello",sw.ToString());
        
        
    }
    [Fact]
    public void Product_Returns_6_When_Given_2_3()
    {
        Func<Decimal,Decimal,Decimal> Product = (d1, d2) => d1 * d2;

        var d1 = 2;
        var d2 = 3;
        
        Assert.Equal(6,Product(d1,d2));



    }
    [Fact]
    public void IsEqual_Returns_True_Given_TwoNummericallyEqualInputs()
    {
        Func<int,string,bool> IsEqual = (i, s) => int.TryParse(s, out var x) ? i == x : throw new Exception("Invalid Input"); 
        
        int i = 22;
        string s = "22";
        
        Assert.True(IsEqual(i,s));
        
        
    }
    
}
