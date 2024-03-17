using System.IO.Compression;

public class CheckListGoal : Goal{
    private int countNeeded;
    private int incrimentCount = 0;
    private string complete = " ";
    private int bonusPoints;
    public CheckListGoal(){

    }
    public CheckListGoal(string import){
        var parts = import.Split("|");
        name = parts[1];
        description = parts[2];
        points = int.Parse(parts[3]);
        incrimentCount = int.Parse(parts[4]);
        countNeeded = int.Parse(parts[5]);
        bonusPoints = int.Parse(parts[6]);
        finished = bool.Parse(parts[7]);
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        countNeeded = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
        Console.WriteLine($"Congrats you set another checklist goal for {points} points and {bonusPoints} bonus points");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{complete}] {name} ({description}) -- Currently Completed : {incrimentCount}/{countNeeded}");
    }

    public override int GetPoints(){
        if(incrimentCount == countNeeded){
            return points + bonusPoints;
        }else if (incrimentCount > countNeeded){
            return points = 0;
        }else{
            return points;
        }
    }
    public override void Record()
    {
        incrimentCount++;
        if(incrimentCount == countNeeded){
            complete = "X";
            finished = true;
        }
    }
    public override string Export()
    {
        return $"CG|{base.Export()}|{incrimentCount}|{countNeeded}|{bonusPoints}|{finished}";
    }
}