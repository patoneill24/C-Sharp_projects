using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class AssignmentCreator(){
    //puts in values for all assignment constucor types to create instances of assignment classes
    private string name;
    private bool completed;
    private string description;
    private int dueDate;
    private int points;
    private int bonusPoints;
    private string checkMark;
    private List<string> tools = new List<string>();
    private List<Assignment> allAssignements = new List<Assignment>();

    
    public void Create(){
        Console.Write("what is the name of the assignment? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of the assignement? ");
        description = Console.ReadLine();
        Console.Write("When is the assignment due?(type 1 for monday, 2 for tuesday...6 for Saturday) ");
        dueDate = int.Parse(Console.ReadLine());
        Console.Write("How many points will you get for completeing the assignement? ");
        points = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points will you get for getting 100% on the assignement: ");
        bonusPoints = int.Parse(Console.ReadLine());
        completed = false;
        checkMark = " ";
        Console.WriteLine("Assignment types: ");
        Console.WriteLine("1. Quiz");
        Console.WriteLine("2. Essay");
        Console.WriteLine("3. Project");
        Console.Write("What type of assignment are you wanting to create? ");
        string assignmentChoice = Console.ReadLine();
        switch(assignmentChoice){
            case "1":
                Console.Write("How many questions are on the Quiz? ");
                int numQuestions = int.Parse(Console.ReadLine());
                Console.Write("How many attempts are allowed? ");
                int numAttempts = int.Parse(Console.ReadLine());
                Console.Write("Is it timed? (true/false): ");
                bool timed = bool.Parse(Console.ReadLine());
                int timeAlloted = 1000000000;
                int numCorrect = 0;
                if(timed == true){
                    Console.Write("How much time is alloted? ");
                    timeAlloted = int.Parse(Console.ReadLine());
                }
                Quiz quiz = new Quiz(name,dueDate,points,checkMark,description,completed,numCorrect,numQuestions,timed,timeAlloted,numAttempts,bonusPoints);
                allAssignements.Add(quiz);
                break;
            case "2":
                Console.Write("When is the roughDraft Due?(enter name of day): ");
                string essayRoughDraftDueDate = Console.ReadLine();
                Console.Write("How many paragraphs are needed? ");
                int numParagraphs = int.Parse(Console.ReadLine());
                Console.Write("What is the required word count? ");
                int wordCount = int.Parse(Console.ReadLine());
                Console.Write("What kind of Citation is needed? ");
                string citatationType = Console.ReadLine();
                int essayScore = 0;
                string essayLetterGrade = "F";
                Essay essay = new Essay(name,dueDate, points,checkMark,description,completed,essayRoughDraftDueDate,numParagraphs,wordCount,citatationType,bonusPoints,essayScore, essayLetterGrade);
                allAssignements.Add(essay);
                break;
            case "3":
                Console.Write("When is the rough draft Due?(enter name of day): ");
                string projectRoughDraftDueDate = Console.ReadLine();
                string tool = "";
                while(tool != "quit"){
                    Console.Write("What tools are needed?(enter as many tools as needed, press enter after tool. If no more tools are need, type 'quit' \n");
                    tool = Console.ReadLine();
                    if(tool != "quit"){
                        tools.Add(tool);
                    }
                }
                Console.Write("Is it a group project?(true/false) ");
                bool groupProject = bool.Parse(Console.ReadLine());
                int groupSize = 1;
                if(groupProject == true){
                    Console.Write("How many people are in your group? ");
                    groupSize = int.Parse(Console.ReadLine());
                }
                int score = 0;
                string projectLetterGrade = "F";
                Project project = new Project(name,dueDate,points,checkMark,description,completed,projectRoughDraftDueDate,tools,groupProject,groupSize,bonusPoints,score, projectLetterGrade);
                allAssignements.Add(project);
                break;
        }
    }

    public List<Assignment> GetAssignments(){
        return allAssignements;
    }
}   