using System.Collections;
using System.ComponentModel;

public  class Calendar{
    AssignmentCreator assignment = new AssignmentCreator();
    CheckList checkList = new CheckList();
    public void createAssignement(){
        assignment.Create();
    }
    public void Display(){
        int points = checkList.GetTotalPoints();
        Console.WriteLine($"\nPoints: {points}");
        assignment.DisplayAssignments();
    }

        public void Record(){
        List<Assignment> allAssignments = assignment.GetAssignments();
        Assignment[] assignments = allAssignments.ToArray();
        Console.WriteLine("Here are all the assignments:");
        for(var i = 0; i < assignments.Count(); i++){
            Console.WriteLine($"{i+1}. {assignments[i].GetName()}");
        }
        Console.Write("Which assignment did you complete? ");
        int completedAssignment = int.Parse(Console.ReadLine());
        assignments[completedAssignment-1].CompleteAssignment();
        int pointsEarned = assignments[completedAssignment-1].GetPoints();
        Console.WriteLine($"Congratulations! You completed the {assignments[completedAssignment-1].GetName()} and earned {pointsEarned} points!");
        checkList.AddPoints(pointsEarned);
        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }
}
