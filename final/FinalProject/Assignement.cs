using System.Collections;
using System.ComponentModel.DataAnnotations;

public class Assignment{
    //parent assignment class, holds shared attribues and methods among children classes
    protected string name;
    protected int dueDate;
    protected int points;
    protected string checkMark;
    protected string description;
    protected bool completed;
    protected int bonusPoints;
    protected int sumPoints;
    public Assignment(string name, int dueDate, int points, string checkMark, string description, bool completed,int bonusPoints){
        this.name = name;
        this.dueDate = dueDate;
        this.points = points;
        this.checkMark = checkMark;
        this.description = description;
        this.completed = completed;
        this.bonusPoints = bonusPoints;
    }
    public int GetDueDate(){
        return dueDate;
    }

    public bool GetStatus(){
        return completed;
    }
    public string GetName(){
        return name;
    }
    public int GetPoints(){
        sumPoints = points + bonusPoints;
        return sumPoints;
    }
    public virtual string DisplayAssignment(){
        return $"[{checkMark}]Name:{name} - Description: {description}";
    }
    public int InputGrade(){
        Console.WriteLine("Hers's how to record your grade: ");
        Console.WriteLine("type 0 for F");
        Console.WriteLine("type 1 for D");
        Console.WriteLine("type 2 for C");
        Console.WriteLine("type 3 for B");
        Console.WriteLine("type 4 for A");
        Console.Write("Enter your grade here: ");
        return int.Parse(Console.ReadLine());
    }

    public string GetGrade(int grade){
        switch(grade){
            case 0:
                return "F";
            case 1:
                return "D";
            case 2:
                return "C";
            case 3:
                return "B";
            case 4:
                return "A";
            default:
                return "F";
        }
    }
    public virtual void CompleteAssignment(){
            completed = true;
            checkMark = "X";
            Console.WriteLine($"Congratulations! You completed another assignment and earned {points} points and {bonusPoints} bonus points!");
    }
}