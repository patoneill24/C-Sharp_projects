class Breathing : Activity{
    public Breathing(string welcomeMessage, string exitMessage, int duration): base(welcomeMessage,exitMessage,duration){

    }

    public void Breath(){
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(duration);
        while(DateTime.Now < finishTime){
            Console.Write("\n\nBreathe in...");
            for(int i = 4; i > 0 ; i--){
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nNow Breathe out...");
            for(int i = 6; i > 0; i--){
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine($"\n\nYou just did {duration} seconds of deep breathing!");
        Spinner();
    }
}