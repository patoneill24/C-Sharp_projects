using System;
using System.ComponentModel.Design;

class Program
{
    private static bool keepGoing = true;
    static void Main(string[] args)
    {
        Console.Clear();
        Activity activity = new Activity();
        while (keepGoing ==true){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    //code for breathing Activity
                    Console.Clear();
                    int breathingDuration = activity.getDuration();
                    Breathing breathing = new Breathing("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Congratulations! You finished another breathing activity!",breathingDuration);
                    breathing.Intro();
                    breathing.getReady();
                    breathing.Breath();
                    breathing.Conclusion();
                    break;
                case "2":
                    //code for listing Activity
                    Console.Clear();
                    int listingDuration = activity.getDuration();
                    Listing listing = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Congratulations! You finished another listing activity!", listingDuration);
                    listing.Intro();
                    listing.getReady();
                    listing.GeneratePrompts();
                    listing.Conclusion();
                    break;
                case "3":
                    //code for Reflecting Activity
                    Console.Clear();
                    int reflectingDuration = activity.getDuration();
                    Reflecting reflecting = new Reflecting("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Congratulations! You have finished another Reflecting Activity!", reflectingDuration);
                    reflecting.Intro();
                    reflecting.getReady();
                    reflecting.GenerateRandomPrompt();
                    reflecting.GenerateRandomQuestions();
                    reflecting.Conclusion();
                    break;
                case "4":
                    //stop program
                    keepGoing = false;
                    break;
            }
        }
    }
}