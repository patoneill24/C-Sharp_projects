using System;

class Program
{
    //private static bool keepRunning;
    static void Main(string[] args)
    {
        Console.Clear();
        Run();
    }

    public static void Run(){
        EternalQuest eternalQuest = new EternalQuest();
        bool keepRunning = true;
        Console.Clear();
        while(keepRunning){
            eternalQuest.DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    eternalQuest.GoalType();
                    break;
                case "2":
                    eternalQuest.DisplayGoals();
                    break;
                case "3":
                    //Save Goals
                    eternalQuest.SaveEvent();
                    break;
                case "4":
                    //Load Goals
                    var lines = eternalQuest.ReadFile();
                    eternalQuest = new EternalQuest(lines);
                    break;
                case "5":
                    //Record Event
                    eternalQuest.RecordEvent();
                    break;
                case "6":
                    //Quit
                    keepRunning = false;
                    break;
            }
        }
    }
}