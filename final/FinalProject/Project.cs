public class Project:Assignment{
    private string roughDraftDueDate;
    private List<String> toolsNeeded = new List<string>();
    private bool groupProject;
    public Project(string name, int dueDate, int points, string checkMark, string description, bool completed, string roughDraftDueDate, List<string> toolsNeeded, bool groupProject):base(name,dueDate,points,checkMark,description,completed){
        this.roughDraftDueDate = roughDraftDueDate;
        this.toolsNeeded = toolsNeeded;
        this.groupProject = groupProject;
    }
    //public override void CompleteAssignment()
    //{
    //    checkMark = "X";
    //    //throw new NotImplementedException();
    //}
    public void DisplayToolsList(){
        Console.WriteLine("Tools Needed: ");
        Console.WriteLine(String.Join("," , toolsNeeded));
    }
    public override string DisplayAssignment()
    {
        DisplayToolsList();
        return $"{base.DisplayAssignment()} - rough draft due date:{roughDraftDueDate} - group project:{groupProject}";
    }
}