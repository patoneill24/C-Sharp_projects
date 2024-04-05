using System.Collections;
using System.ComponentModel;

public  class Calendar{
    //adds each instance of assignment class to a day of the week 
    //and displays the days of the week and the assignments due that day
    private List<Assignment> Monday = new List<Assignment>();
    private List<Assignment> Tuesday = new List<Assignment>();
    private List<Assignment> Wednsday = new List<Assignment>();
    private List<Assignment> Thursday = new List<Assignment>();
    private List<Assignment> Friday = new List<Assignment>();
    private List<Assignment> Saturday = new List<Assignment>();

    public void Days(List<Assignment>allAssignments){
        foreach(Assignment assignment in allAssignments){
            int dueDate = assignment.GetDueDate();
            switch(dueDate){
                case 1:
                    Monday.Add(assignment);
                    break;
                case 2:
                    Tuesday.Add(assignment);
                    break;
                case 3:
                    Wednsday.Add(assignment);
                    break;
                case 4:
                    Thursday.Add(assignment);
                    break;
                case 5:
                    Friday.Add(assignment);
                    break;
                case 6:
                    Saturday.Add(assignment);
                    break;
            }
        }
    }

    public void DisplayList(List<Assignment> assignments){
        foreach(Assignment assignment in assignments){
            Console.WriteLine($"\n{assignment.DisplayAssignment()}");
        }
    }

    public void Display(){
        Days(AssignmentCreator.GetAssignments());
        AssignmentCreator.GetAssignments().Clear();
        Console.WriteLine("\nMonday:");
        DisplayList(Monday);
        Console.WriteLine("\nTuesday:");
        DisplayList(Tuesday);
        Console.WriteLine("\nWednsday:");
        DisplayList(Wednsday);
        Console.WriteLine("\nThursday:");
        DisplayList(Thursday);
        Console.WriteLine("\nFriday:");
        DisplayList(Friday);
        Console.WriteLine("\nSaturday:");
        DisplayList(Saturday);
        Console.Write("\nPress any key to continue: ");
        Console.ReadLine();
    }
}

