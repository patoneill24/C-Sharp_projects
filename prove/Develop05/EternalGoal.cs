public class EternalGoal : Goal{
    public EternalGoal(){

    }
    public EternalGoal(string name, string description, int points):base(name,description,points){
        
    }
    public EternalGoal(string import){
        var parts = import.Split("|");
        name = parts[1];
        description = parts[2];
        points = int.Parse(parts[3]);
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine($"Congrats! you made another Eternal Goal for {points} points!");
    }

    public override void DisplayGoal(){
        Console.WriteLine($"[ ] {name} ({description})");
    }
    public override void Record()
    {
        Console.WriteLine("Good Job, you accomplished a daily goal! Keep it up!");
    }
    public override string Export()
    {
        return $"EG|{base.Export()}";
    }
}