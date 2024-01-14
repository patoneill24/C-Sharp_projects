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
            if (gradeNumber <= 93) 
            {
                gradeLetter = "A-";
            }
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            if(gradeNumber >= 87)
            {
                gradeLetter = "B+";
            }
            else if (gradeNumber <= 83)
            {
                gradeLetter = "B-";
            }
            else {
                gradeLetter = "B";
            }
        }
        else if (gradeNumber >= 70)
        {
            if(gradeNumber >= 77)
            {
                gradeLetter = "C+";
            }
            else if (gradeNumber <= 73)
            {
                gradeLetter = "C-";
            }
            else {
                gradeLetter = "C";
            }
        }
        else if (gradeNumber >= 60)
        {
            if(gradeNumber >= 67)
            {
                gradeLetter = "D+";
            }
            else if (gradeNumber <= 63)
            {
                gradeLetter = "D-";
            }
            else {
                gradeLetter = "D";
            }
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