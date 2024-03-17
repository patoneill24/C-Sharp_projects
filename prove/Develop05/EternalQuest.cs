using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class EternalQuest{

    public EternalQuest(){

    }
    private int goalNumber;
    private string goalChoice;
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;
    SimpleGoal simpleGoal = new SimpleGoal();
    EternalGoal eternalGoal = new EternalGoal();
    CheckListGoal checkListGoal = new CheckListGoal();
    private int goalPoints;

    public void DisplayMenu(){
        Console.WriteLine($"You have {totalPoints} points\n");
        Console.WriteLine("Menu Option: ");
        Console.WriteLine("\t1.Create New Goal");
        Console.WriteLine("\t2.List Goals");
        Console.WriteLine("\t3.Save Goals");
        Console.WriteLine("\t4.Load Goals");
        Console.WriteLine("\t5.Record Event");
        Console.WriteLine("\t6.Quit");
    }
    public void GoalType(){
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("\t1.Simple Goal");
        Console.WriteLine("\t2.Eternal Goal");
        Console.WriteLine("\t3.Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = Console.ReadLine();
        switch(goalChoice){
            case "1":
                simpleGoal.CreateGoal();
                goals.Add(simpleGoal);
                break;
            case "2":
                eternalGoal.CreateGoal();
                goals.Add(eternalGoal);
                break;    
            case "3":
                checkListGoal.CreateGoal();
                goals.Add(checkListGoal);
                break; 
        }
    }
    public void DisplayGoals(){
        Console.WriteLine("\nGoals: ");
        foreach(Goal goal in goals){
            goal.DisplayGoal();
            }
    }

    public int RecordEvent(){
        Console.WriteLine("The Goals are: ");
        foreach(Goal goal in goals){
            int index = goals.IndexOf(goal);
            Console.WriteLine($"{index + 1}. {goal.GetName()}");
        }
        Console.Write("Which goal do you want to record? ");
        goalNumber = int.Parse(Console.ReadLine());
        if(goals[goalNumber-1].GetFinished() == true){
            Console.WriteLine("Goal already completed!");
        }
        goals[goalNumber-1].Record();
        goalPoints = goals[goalNumber-1].GetPoints();
        totalPoints += goalPoints;
        return totalPoints;
    }

    public EternalQuest(string[] import){
        goals = new List<Goal>();
        totalPoints += int.Parse(import[0]);
        foreach(var line in import){
            if (line.Contains("EG")){
                    eternalGoal = new EternalGoal(line);
                    goals.Add(eternalGoal);
            }else if (line.Contains("SG")){
                    simpleGoal = new SimpleGoal(line);
                    goals.Add(simpleGoal);
            }else if (line.Contains("CG")){
                    checkListGoal = new CheckListGoal(line);
                    goals.Add(checkListGoal);
                    break;
            }
        }
    }

    public void SaveEvent(){
        Console.Write("What filename do you want to save this under? ");
        string name = Console.ReadLine();
        WriteFile(name);
    }

    public string[] ExportData(){
        var exportLines = new List<string>();
        foreach(Goal goal in goals){
            exportLines.Add(goal.Export());
        }
        return exportLines.ToArray();
    }

    public void WriteFile(string fileName){
        var array = ExportData();
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(totalPoints);
            foreach(var item in array){
                outputFile.WriteLine(item);
            }
        }
    }

    public string[] ReadFile(){
        Console.Write("What file would you like to open: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        return lines;
    }
}