using System.Collections;
using System.ComponentModel;

public  class Calendar{
    //puts whole program together as it executes code for creating, displaying and recording assignements
    private int pointsEarned;
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
