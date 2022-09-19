namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test1()
    {
      //  Func<string> reverseString = s => Console.WriteLine(s.Reverse());
        
        
    }
    [Fact]
    public void Test2()
    {
   
        Func<Decimal,Decimal,Decimal> Product = (d1, d2) => d1 * d2; 
        
        
        
        
    }
    [Fact]
    public void Test3()
    {
        Func<int,string,bool> IsEqual = (i, s) => int.TryParse(s, out var x) ? i == x : throw new Exception("Invalid Input"); 
    }
    
}
