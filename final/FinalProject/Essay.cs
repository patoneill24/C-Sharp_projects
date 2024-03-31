public class Essay:Assignment{
    private string roughDraftDueDate;
    private int numParagraphs;
    private int wordCount;
    private string citationType;
    public Essay(string name, int dueDate, int points, string checkMark, string description, bool completed, string roughDraftDueDate, int numParagraphs, int wordCount, string citationType):base(name,dueDate,points,checkMark,description,completed){
        this.roughDraftDueDate = roughDraftDueDate;
        this.numParagraphs = numParagraphs;
        this.wordCount = wordCount;
        this.citationType = citationType;
    }
    //public override void CompleteAssignment()
    //{
    //    checkMark = "X";
    //    //throw new NotImplementedException();
    //}
    public override string DisplayAssignment()
    {
        return $"{base.DisplayAssignment()} - Rough draft due date: {roughDraftDueDate} - required word count:{wordCount} - required paragraph count: {numParagraphs} - required citation type: {citationType}";
    }
}