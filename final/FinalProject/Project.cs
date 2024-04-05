using System.Runtime.CompilerServices;

public class Project:Assignment{
    //Gets track of info about projects due
    private string roughDraftDueDate;
    private int score;
    private string letterGrade;
    private List<String> toolsNeeded = new List<string>();
    private bool groupProject;
    private int groupSize;
    public Project(string name, int dueDate, int points, string checkMark, string description, bool completed, string roughDraftDueDate, List<string> toolsNeeded, bool groupProject,int groupSize, int bonusPoints, int score, string letterGrade):base(name,dueDate,points,checkMark,description,completed,bonusPoints){
        this.roughDraftDueDate = roughDraftDueDate;
        this.toolsNeeded = toolsNeeded;
        this.groupProject = groupProject;
        this.score = score;
        this.groupSize = groupSize;
    }
    public void DisplayToolsList(){
        Console.WriteLine("\nTools Needed: ");
        Console.WriteLine(String.Join("," , toolsNeeded));
    }

    public override void CompleteAssignment()
    {
        score = InputGrade();
        letterGrade = GetGrade(score);
        if(score < 4){
            bonusPoints = 0;
        }
        base.CompleteAssignment();
    }
    public override string DisplayAssignment()
    {
        DisplayToolsList();
        if (completed == true){ 
            return $"{base.DisplayAssignment()} - rough draft due date:{roughDraftDueDate} - group project:{groupProject}- group size: {groupSize} - Grade: {letterGrade}";
        }else{
            return $"{base.DisplayAssignment()} - rough draft due date:{roughDraftDueDate} - group project:{groupProject}- group size: {groupSize}";
        }
    }
}