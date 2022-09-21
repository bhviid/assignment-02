namespace Assignment2;
using System.Linq;
public class Queries
{
    //Extenson Queries:
    // Wizards invented by Rowling. Only return the names.
    public static IEnumerable<String> ExtensionRowlingWizards(){
        var wizards = WizardCollection.Create();

        return wizards
                .Where(w => w.Creator.Contains("Rowling"))
                .Select(w => w.Name);
    }

    // The year the first sith lord was introduced. Let's define a sith lord to be one named Darth something.
    public static int? ExtensionFirstSith(){
        var wizards = WizardCollection.Create();

        return wizards
                .Where(w => w.Name.Contains("Darth"))
                .Select(w => w.Year).FirstOrDefault();
    }

    // Unique list of wizards from the Harry Potter books - only return name and year (as a value tuple).
    public static IEnumerable<(String, int?)> ExtensionUniqueHarryPotterWizards(){
        var wizards = WizardCollection.Create();

        return wizards
                .Where(w => w.Creator.Contains("Rowling"))
                .Select(w => (w.Name, w.Year))
                .Distinct();
    }

    // List of wizard names grouped by creator in reverse order by creator name and then wizard name.
    //Based on the description of the method I have interpreted that it is supposed to order by descending creator and then ascending name
    public static IEnumerable<String> ExtensionSortedWizards(){
        var wizards = WizardCollection.Create();
        
        return wizards
                .OrderByDescending(w => w.Creator)
                .ThenBy(w => w.Name)
                .Select(w => w.Name);
    }


    //Linq Queries:
    // Wizards invented by Rowling. Only return the names.
    public static IEnumerable<String> RowlingWizards(){
        var wizards = WizardCollection.Create();

        return
            from w in wizards
            where w.Creator.Contains("Rowling")
            select w.Name;

    }

    // The year the first sith lord was introduced. Let's define a sith lord to be one named Darth something.
    //First som i den første på listen eller den med det laveste year?
    public static int? FirstSith(){
        var wizards = WizardCollection.Create();

        return
            (from w in wizards
            where w.Name.Contains("Darth")
            select w.Year).FirstOrDefault();
    }

    // Unique list of wizards from the Harry Potter books - only return name and year (as a value tuple).
    public static IEnumerable<(string, int?)> UniqueHarryPotterWizards(){
        var wizards = WizardCollection.Create();
        
        return
            (from w in wizards
            where w.Medium.Equals("Harry Potter")
            select (w.Name, w.Year)).Distinct();
    }

    // List of wizard names grouped by creator in reverse order by creator name and then wizard name.
    //Based on the description of the method I have interpreted that it is supposed to order by descending creator and then ascending name
    public static IEnumerable<String> SortedWizards(){
        var wizards = WizardCollection.Create();

        return
            from w in wizards
            orderby w.Creator descending, w.Name
            select w.Name;
    }

}
