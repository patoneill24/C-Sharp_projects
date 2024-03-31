public class Quiz: Assignment{
    private int numCorrect;
    private int numQuestions;
    private bool timed;
    private int timeAlloted;
    private int numAttempts;

    public Quiz(string name, int dueDate, int points, string checkMark, string description, bool completed,int numCorrect, int numQuestions, bool timed, int timeAlloted,int numAttempts):base(name,dueDate,points,checkMark,description,completed){
        this.numCorrect = numCorrect;
        this.numQuestions = numQuestions;
        this.timed = timed;
        this.timeAlloted = timeAlloted;
        this.numAttempts = numAttempts;
    }
    public override void CompleteAssignment()
    {
        base.CompleteAssignment();
        Console.Write("How many questions did you get correct? ");
        numCorrect = int.Parse(Console.ReadLine());
        //throw new NotImplementedException();
    }
    public override string DisplayAssignment()
    {
        return $"{base.DisplayAssignment()} - Timed: {timed} - Time Alloted: {timeAlloted} minutes - Score: {numCorrect}/{numQuestions} - number of Attempts: {numAttempts}";
    }
}