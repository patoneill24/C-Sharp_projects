using System.Dynamic;

public class Activity{
    protected string welcomeMessage;
    protected string exitMessage;
    private List<string> animations = new List<string>();
    protected int duration;
    public Activity(){

    }
    public Activity(string welcomeMessage, string exitMessage, int duration){
        this.welcomeMessage = welcomeMessage;
        this.exitMessage = exitMessage;
        this.duration = duration;
    }
    public void Intro(){
        Console.WriteLine(welcomeMessage);
        Console.Write("For how many seconds would you like to do this activity for: ");
        duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void getReady(){
        Console.WriteLine("Get ready...");
        Spinner();
    }
    public void Begin(){
        Console.Write("You may bein in: ");
        for(int i = 3; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public int getDuration(){
        return duration;
    }

    public void Spinner(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        while (DateTime.Now < futureTime){
            foreach(string a in animations){
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            
            if (DateTime.Now == futureTime){
                break;
            }
        }
    }

    public void Conclusion(){        
        Console.WriteLine($"\n{exitMessage}");
        Spinner();
        Console.Clear();
    }
}