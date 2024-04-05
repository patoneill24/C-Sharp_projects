public class Planner{
    //Calls and executes create, display and record functions and keeps track of total points
    private int pointsEarned;
    private int totalPoints;
    AssignmentCreator newAssignment = new AssignmentCreator();
    Calendar calendar = new Calendar();

    public void AddPoints(int value){
        totalPoints += value;
    }

    public void createAssignement(){
        newAssignment.Create();
    }
    public void DisplayCalendar(){
        Console.WriteLine($"\nPoints: {totalPoints}");
        calendar.Display();
    }

    public void Record(){
        List<Assignment> toDo = AssignmentCreator.ToDoAssignments();
        for(var i = 0; i < toDo.Count; i++){
            if(toDo[i].GetStatus() == true){
                toDo.Remove(toDo[i]);
            }
        }
        Assignment[] assignments = toDo.ToArray();
        Console.WriteLine("Here are all the assignments:");
        for(var i = 0; i < assignments.Count(); i++){
            Console.WriteLine($"{i+1}. {assignments[i].GetName()}");
        }
        if(toDo.Count == 0){
            Console.Write("\nYou don't have any assignments left to do. Good job! Press any key to continue... ");
            Console.ReadLine();
        }else{
            Console.Write("Which assignment did you complete? ");
            int completedAssignment = int.Parse(Console.ReadLine());
            assignments[completedAssignment-1].CompleteAssignment();
            pointsEarned = assignments[completedAssignment-1].GetPoints();
            AddPoints(pointsEarned);
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}