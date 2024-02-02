namespace JournalApp;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Run();
    }
    static public void Run(){
    bool keepGoing = true;
    Journal journal = new();
    while(keepGoing){
        DisplayMenu();
        Console.Write("What would you like to do? ");
        string number = Console.ReadLine();

        switch(number){
            case "1":
                Entry entry = new Entry();
                entry.prompt = entry.GetPrompt();
                Console.WriteLine($"\n{entry.prompt}");
                Console.Write("> ");
                entry.response = Console.ReadLine();
                entry.date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                journal.entries.Add(entry);
                break;
            case "2":
                journal.Display();
                break;
            case "3": 
                var lines= journal.Export();
                WriteFile(lines);       
                break;
            case "4": 
                lines = ReadFile();
                journal = new Journal(lines);
                break;
            case "5":
                keepGoing = false;
                break;
            }
        }
    }
    static  public void DisplayMenu()
    {
        Console.WriteLine("\n1. Write a new Entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit\n"); 
    }

    static string[] ReadFile()
    {
        Console.Write("\nEnter filename: ");
        var fileName = Console.ReadLine();
        return System.IO.File.ReadAllLines(fileName);
    }
    static void WriteFile(string[] lines)
    {
        Console.Write("\nEnter filename: ");
        var fileName = Console.ReadLine();
        System.IO.File.WriteAllLines(fileName, lines);
    }

}


