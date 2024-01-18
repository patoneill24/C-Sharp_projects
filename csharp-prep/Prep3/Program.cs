using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        int count = 0;
        while(count < 5){
            System.Console.WriteLine($"count = {count}");

            ++count;
        }
        int moreCount = 0;
        do {
            System.Console.WriteLine($"moreCount = {moreCount++}");
        } while(moreCount < 5);

        for (var i = 10; i > 5; --i)
        {
            System.Console.WriteLine($"i = {i}");
        }

        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 11);
        int guess;
        
        do 
        {
            Console.Write("Guess a number from 1 to 11: ");
            guess = int.Parse(Console.ReadLine());
            if (guess > random)
            {
                System.Console.WriteLine("too high, pick a lower number");
            } 
            else if (guess < random)
            {
                System.Console.WriteLine("too low, pick a higher number.");
            } 
            else 
            {
                System.Console.WriteLine("You guessed the right number!");
                break;
            }
        } while(random != guess);
    }
}