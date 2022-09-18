using System.Text.Json;

namespace Assignment2.Lib;

public class Student
{
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public Status Status { get; set; }
    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
   
}           

public enum Status
{
    New,
    Active,
    Dropout,
    Graduated   
}