public class Essay:Assignment{
    //gets track of info about essays due
    private string roughDraftDueDate;
    private int numParagraphs;
    private int wordCount;
    private int score;
    private string citationType;
    private string letterGrade;
    public Essay(string name, int dueDate, int points, string checkMark, string description, bool completed, string roughDraftDueDate, int numParagraphs, int wordCount, string citationType,int bonusPoints,int score,string letterGrade):base(name,dueDate,points,checkMark,description,completed,bonusPoints){
        this.roughDraftDueDate = roughDraftDueDate;
        this.numParagraphs = numParagraphs;
        this.wordCount = wordCount;
        this.citationType = citationType;
        this.score = score;
        this.letterGrade = letterGrade;
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
        if (completed == true){
            return $"{base.DisplayAssignment()} - Rough draft due date: {roughDraftDueDate} - required word count:{wordCount} - required paragraph count: {numParagraphs} - required citation type: {citationType} - Grade: {letterGrade}";
        }else{
            return $"{base.DisplayAssignment()} - Rough draft due date: {roughDraftDueDate} - required word count:{wordCount} - required paragraph count: {numParagraphs} - required citation type: {citationType}";
        }
    }
}