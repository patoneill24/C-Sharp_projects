using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        int Add2 (int number, string name)
        {
            return number + 2;
        }

        void PrintName(string name)
        {
            System.Console.WriteLine(name);
        }

        int answer = Add2(10,"bob");
        PrintName($"Bob is {answer}");

        var i = 12;
        {
            var y = 10;
            y = i + 3;
            i = y + 4;
        }

        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        int SquareNumber(int num)
        {
            return num * num;
        }

        void DisplayResult(int squared, int num, string name){
            Console.WriteLine($"{name}, your favorite number is {num}, and when you square that you get {squared}");
        }

        DisplayWelcome();

        string name = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squared = SquareNumber(favoriteNumber);

        DisplayResult(squared,favoriteNumber, name);


    }
}