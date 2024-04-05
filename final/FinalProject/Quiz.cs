public class Quiz: Assignment{
    //keeps track of info about quizzes due
    private int numCorrect;
    private int numQuestions;
    private bool timed;
    private int timeAlloted;
    private int numAttempts;

    public Quiz(string name, int dueDate, int points, string checkMark, string description, bool completed,int numCorrect, int numQuestions, bool timed, int timeAlloted,int numAttempts,int bonusPoints):base(name,dueDate,points,checkMark,description,completed,bonusPoints){
        this.numCorrect = numCorrect;
        this.numQuestions = numQuestions;
        this.timed = timed;
        this.timeAlloted = timeAlloted;
        this.numAttempts = numAttempts;
    }
    public override void CompleteAssignment()
    {
        Console.Write($"How many problems did you get correct out of {numQuestions} questions? ");
        numCorrect = int.Parse(Console.ReadLine());
        if(numCorrect < numQuestions){
            bonusPoints = 0;
        }
        base.CompleteAssignment();
    }
    public override string DisplayAssignment()
    {
        if(timed == true){
            return $"{base.DisplayAssignment()} - Timed: {timed} - Time Alloted: {timeAlloted} minutes - Score: {numCorrect}/{numQuestions} - number of Attempts Allowed: {numAttempts}";
        }else{
            return $"{base.DisplayAssignment()} - Timed: {timed} - Time Alloted: N/A - Score: {numCorrect}/{numQuestions} - number of Attempts Allowed: {numAttempts}";
        }
    }
}