using System.ComponentModel.DataAnnotations;

public class Assignment{
    protected string name;
    protected int dueDate;
    protected int points;
    protected string checkMark;
    protected string description;
    protected bool completed;
    //protected int bonusPoints;
    public Assignment(string name, int dueDate, int points, string checkMark, string description, bool completed){
        this.name = name;
        this.dueDate = dueDate;
        this.points = points;
        this.checkMark = checkMark;
        this.description = description;
        this.completed = completed;
        //this.bonusPoints = bonusPoints;
    }
    public int GetDueDate(){
        return dueDate;
    }

    public string GetName(){
        return name;
    }
    public int GetPoints(){
        return points;
    }
    public virtual string DisplayAssignment(){
        return $"[{checkMark}]Name:{name} - Description: {description}";
    }
    public virtual void CompleteAssignment(){
        completed = true;
        checkMark = "X";
        
    }
}