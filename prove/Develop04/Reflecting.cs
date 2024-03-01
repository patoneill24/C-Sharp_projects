using System.Formats.Asn1;

class Reflecting : Activity{
    public Reflecting(string welcomeMessage, string exitMessage, int duration): base(welcomeMessage, exitMessage, duration){
        
    }
    private List<string>prompts = new List<string>();
    private List<int>chosenPrompts = new List<int>();

    public void GenerateRandomPrompt(){
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        Random rnd= new Random();
        int randomIndex = rnd.Next(0,prompts.Count);
        Console.WriteLine($"Consider the following Prompt:\n\n---{prompts[randomIndex]}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.Write("");
        Console.ReadLine();
    }
    public void GenerateRandomQuestions(){
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Thread.Sleep(2000);
        Begin();
        Console.Clear();
        List<string>questions = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?", 
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(duration);
        while(DateTime.Now < finishTime){
            Random rnd = new Random();
            int randomNum = rnd.Next(0,questions.Count);
            if(chosenPrompts.Contains(randomNum)){
                while(chosenPrompts.Contains(randomNum)){
                    if(questions.Count == chosenPrompts.Count){
                        break;
                    }
                    rnd = new Random();
                    randomNum = rnd.Next(0,questions.Count);
                    if(chosenPrompts.Contains(randomNum)==false){
                        break;
                    }
                }
            }
            Console.Write($"\n\n>{questions[randomNum]} ");
            Spinner();
            chosenPrompts.Add(randomNum);
        }
        Console.WriteLine($"\n\nWell Done! You completed {duration} seconds of reflecting!");
        Spinner();
    }
}