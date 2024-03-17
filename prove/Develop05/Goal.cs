using System.Reflection.Metadata;

public abstract class Goal{
    protected int points;
    protected string description;
    protected string name;
    protected bool finished = false;
    public Goal(){

    }
    public virtual string Export(){
        return $"{name}|{description}|{points}";
    }
    public virtual void CreateGoal(){
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }

    public string GetName(){
        return name;
    }

    public bool GetFinished(){
        return finished;
    }

    public virtual int GetPoints(){
        return points;
    }
    public abstract void DisplayGoal();
    public abstract void Record();
}