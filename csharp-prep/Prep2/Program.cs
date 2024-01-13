using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string gradeLetter = "";
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);
        if (gradeNumber >= 90) 
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else{
            gradeLetter = "F";
        }

        Console.WriteLine($"Your Grade is a(n) {gradeLetter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class, better luck next time!");
        }
    }
}