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
    public Goal(string name, string description, int points){
        this.name = name;
        this.description = description;
        this.points = points;
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

    public int GetPoints(){
        return points;
    }
    //public void Display(){
    //    foreach(Goal goal in goals){
    //        goal.DisplayGoal();
    //    }
    //}
    public abstract void DisplayGoal();
    //protected abstract void Import();
    //protected abstract void Export();
    public abstract void Record();
}