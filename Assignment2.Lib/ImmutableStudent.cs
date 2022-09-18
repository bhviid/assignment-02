using System.Text.Json;

namespace Assignment2.Lib;

public record ImmutableStudent(int Id, string GivenName, string Surname, Status Status, DateTime StartDate,
    DateTime EndDate, DateTime GraduationDate)
{
   
}
