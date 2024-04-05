using System;
using System.Configuration.Assemblies;

class Program
{
    //runs the application and creates an instance of the calendar class 
    static void Main(string[] args)
    {
        Run();
    }

    static void DisplayMenu(){
        Console.WriteLine("Here's your options: ");
        Console.WriteLine("1. Create Assignemnt");
        Console.WriteLine("2. Display Assignments");
        Console.WriteLine("3. Record Assignement");
        Console.WriteLine("4. Quit");
    }

    static void Run(){
        Planner planner = new Planner();
        bool keepRunning = true;
        while(keepRunning){
            Console.Clear();
            Console.WriteLine("Hello! Welcome to my Weekly Homework Planner application! This app allows you to list the assignements you have due for the upcoming week. As you list the assignements you can choose to have the assignements displayed and it will display the assignements due on each day of the week. You can also record when you finish an assignement and you'll receive points based on the assignements you complete. Below is your menu! ");
            DisplayMenu();
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    planner.createAssignement();
                    break;
                case "2":
                    Console.Clear();
                    planner.DisplayCalendar();
                    break;
                case "3":
                    Console.Clear();
                    planner.Record();
                    break;
                case "4":
                    keepRunning = false;
                    break;
            }
        }
    }
}