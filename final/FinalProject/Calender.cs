using System.Collections;
using System.ComponentModel;

public  class Calendar{
    //adds each instance of assignment class to a day of the week
    //puts whole program together as it executes code for creating, displaying and recording assignements
    private int pointsEarned;
    private List<Assignment> Monday = new List<Assignment>();
    private List<Assignment> Tuesday = new List<Assignment>();
    private List<Assignment> Wednsday = new List<Assignment>();
    private List<Assignment> Thursday = new List<Assignment>();
    private List<Assignment> Friday = new List<Assignment>();
    private List<Assignment> Saturday = new List<Assignment>();
    AssignmentCreator assignmentCreator = new AssignmentCreator();
    CheckList checkList = new CheckList();
    public void createAssignement(){
        assignmentCreator.Create();
    }

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

    public void DisplayAssignments(){
        Days(assignmentCreator.GetAssignments());
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

    public void Display(){
        int points = checkList.GetTotalPoints();
        Console.WriteLine($"\nPoints: {points}");
        DisplayAssignments();
    }

    public void Record(){
        List<Assignment> allAssignments = assignmentCreator.GetAssignments();
        for(var i = 0; i < allAssignments.Count; i++){
            if(allAssignments[i].GetStatus() == true){
                allAssignments.Remove(allAssignments[i]);
            }
        }
        Assignment[] assignments = allAssignments.ToArray();
        Console.WriteLine("Here are all the assignments:");
        for(var i = 0; i < assignments.Count(); i++){
            Console.WriteLine($"{i+1}. {assignments[i].GetName()}");
        }
        if(allAssignments.Count == 0){
            Console.Write("\nYou don't have any assignments left to do. Good job! Press any key to continue... ");
            Console.ReadLine();
        }else{
            Console.Write("Which assignment did you complete? ");
            int completedAssignment = int.Parse(Console.ReadLine());
            assignments[completedAssignment-1].CompleteAssignment();
            pointsEarned = assignments[completedAssignment-1].GetPoints();
            checkList.AddPoints(pointsEarned);
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

