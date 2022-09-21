namespace Assignment2.Tests;
using static Assignment2.Queries;

public class QueriesTests
{
    [Fact]
    public void Extension_RowlingWizards()
    {
        // Arrange
        var expected = new List<String>{
            "Harry Potter", 
            "Harry Potter", 
            "Harry Potter", 
            "Hermione Granger", 
            "Ronald Weasley", 
            "Albus Dumbledore", 
            "Voldemort", 
            "Severus Snape"
        };
        
        // Act
        var actual = ExtensionRowlingWizards();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Extension_FirstSith()
    {
        // Arrange
        var expected = 1977;

        // Act
        var actual = ExtensionFirstSith();
    
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Extension_UniqueHarryPotterWizards()
    {
        // Arrange
        var expected = new List<(string, int?)>{
            ("Harry Potter", 1997), 
            ("Hermione Granger", 1997), 
            ("Ronald Weasley", 1997), 
            ("Albus Dumbledore", 1997), 
            ("Voldemort", 1997), 
            ("Severus Snape", 1997)
        };                               
    
        // Act
        var actual = ExtensionUniqueHarryPotterWizards();
    
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Extension_SortedWizards()
    {
        // Arrange
        var expected = new List<String>{
            "Dr.Strange",
            "Gandalf",
            "Sauron",
            "Sirius Black",
            "Albus Dumbledore",
            "Harry Potter",
            "Harry Potter",
            "Harry Potter",
            "Hermione Granger",
            "Ronald Weasley",
            "Severus Snape",
            "Voldemort",
            "Darth Vader",
            "Jafar"
        };

        // Act
        var actual = ExtensionSortedWizards();
    
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Linq_RowlingWizards()
    {
        // Arrange
        var expected = new List<String>{
            "Harry Potter", 
            "Harry Potter", 
            "Harry Potter", 
            "Hermione Granger", 
            "Ronald Weasley", 
            "Albus Dumbledore", 
            "Voldemort", 
            "Severus Snape"
        };

        // Act
        var actual = RowlingWizards();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Linq_FirstSith()
    {
        // Arrange
        var expected = 1977;

        // Act
        var actual = FirstSith();
    
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Linq_UniqueHarryPotterWizards()
    {
        // Arrange
        var expected = new List<(string, int?)>{
            ("Harry Potter", 1997), 
            ("Hermione Granger", 1997), 
            ("Ronald Weasley", 1997), 
            ("Albus Dumbledore", 1997), 
            ("Voldemort", 1997), 
            ("Severus Snape", 1997)
        };
        
        // Act
        var actual = UniqueHarryPotterWizards();
    
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Linq_SortedWizards()
    {
        // Arrange
        var expected = new List<String>{
            "Dr.Strange",
            "Gandalf",
            "Sauron",
            "Sirius Black",
            "Albus Dumbledore",
            "Harry Potter",
            "Harry Potter",
            "Harry Potter",
            "Hermione Granger",
            "Ronald Weasley",
            "Severus Snape",
            "Voldemort",
            "Darth Vader",
            "Jafar"
        };

        // Act
        var actual = SortedWizards();
    
        // Assert
        Assert.Equal(expected, actual);
    }
}
