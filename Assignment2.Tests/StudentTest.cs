namespace Assignment2.Tests;

public class StudentTest
{
    [Fact]
    public void Student_ToString_Given_Default_Returns_Json()
    {
        Console.WriteLine(new Student().ToString());
                        
        Assert.Equal("{\"Id\":0,\"GivenName\":null,\"Surname\":null,\"Status\":0,\"StartDate\":\"0001-01-01T00:00:00\",\"EndDate\":\"0001-01-01T00:00:00\",\"GraduationDate\":\"0001-01-01T00:00:00\"}",new Student().ToString());
    }

    [Fact]
    public void ImmutableStudentTest()
    {
        DateTime time = DateTime.Now;
        ImmutableStudent s1 = new ImmutableStudent(1, "John", "Doe", Status.Dropout, time.AddYears(-10), time.AddMonths(-119), default);
        
        ImmutableStudent s2 = new ImmutableStudent(1, "John", "Doe", Status.Dropout, time.AddYears(-10), time.AddMonths(-119), default);
        
        Assert.Equal(s1,s2);
    }
    [Fact]
    public void ImmutableStudentTest2()
    {
        DateTime time = DateTime.Now; 
        Console.WriteLine(new ImmutableStudent(1, "John", "Doe", Status.Dropout, time.AddYears(-10), time.AddMonths(119), default).ToString());
        
        Assert.Equal("ImmutableStudent { Id = 1, GivenName = John, Surname = Doe, Status = Dropout, StartDate = "+ time.AddYears(-10) + ", EndDate = "+ time.AddMonths(-119) + ", GraduationDate = 1/1/0001 12:00:00 AM }", new ImmutableStudent(1, "John", "Doe", Status.Dropout, time.AddYears(-10), time.AddMonths(-119), default).ToString());
    }
}

