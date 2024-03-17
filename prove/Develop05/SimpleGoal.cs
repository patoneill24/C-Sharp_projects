using System.Dynamic;

public class SimpleGoal: Goal{
    private string complete = " ";
    public SimpleGoal(){

    }
    public SimpleGoal(string import){
        var parts = import.Split("|");
        name = parts[1];
        description = parts[2];
        points = int.Parse(parts[3]);
        finished = bool.Parse(parts[4]);
        complete = parts[5];
    }

    public override string Export(){
        return $"SG|{base.Export()}|{finished}|{complete}";
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine($"Congrats! You made another goal for {points} points!");
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{complete}] {name} ({description})");
    }
    public override void Record(){
        complete = "X";
        finished = true;
    }
}