using System.Reflection.Metadata.Ecma335;

class Listing : Activity{
    public Listing(string welcomeMessage, string exitMessage, int duration): base(welcomeMessage,exitMessage,duration){

    }
    private int questionsAnswered = 0;
    public void GeneratePrompts(){
        List<string> listingPrompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random rnd = new Random();
        int randomIndex = rnd.Next(0,listingPrompts.Count);
        Console.WriteLine("List as many prompts as you can to the following prompt:");
        Console.WriteLine($"\n---{listingPrompts[randomIndex]}---");
        Begin();
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(duration);
        while(DateTime.Now < finishTime){
            Console.Write(">");
            Console.ReadLine();
            questionsAnswered++;
        }
        Console.WriteLine($"\nWell done! You listed {questionsAnswered} things in {duration} seconds!");
        Spinner();
    }
}