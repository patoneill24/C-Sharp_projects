using System;
using System.Configuration.Assemblies;

class Program
{
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
        Calendar calendar = new Calendar();
        bool keepRunning = true;
        while(keepRunning){
            Console.Clear();
            Console.WriteLine("Hello! Welcome to my Weekly Homework Planner application! This app allows you to list the assignements you have due for the upcoming week. As you list the assignements you can choose to have the assignements displayed and it will display the assignements due on each day of the week. You can also record when you finish an assignement and you'll receive points based on the assignements you complete. Below is your menu! ");
            DisplayMenu();
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    calendar.createAssignement();
                    break;
                case "2":
                    Console.Clear();
                    calendar.Display();
                    break;
                case "3":
                    Console.Clear();
                    calendar.Record();
                    //code for recording an assignement
                    break;
                case "4":
                    keepRunning = false;
                    break;
            }
        }
    }
}