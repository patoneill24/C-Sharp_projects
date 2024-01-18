using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> myInts = new List<int>();
        var otherInts = new List<int>();

        myInts.Add(10);
        myInts.Add(24);

        List<int> SortNumbers(List<int> numbers)
        {
        // Sort the list in ascending order
        numbers.Sort();

        // Return the sorted list
        return numbers;
        }

        List<int> sortedNumbers = SortNumbers(otherInts);


        int number;
        do {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            otherInts.Add(number);
        }while(number != 0);

        double counter = 0.0;

        int max_value = 0;

        int min_value = 999999999;

        foreach(var k in otherInts) {
            System.Console.WriteLine($"list item = {k}");
            counter += k;
            if (k > max_value) {
                max_value = k;
            }

            if (k == 0){
                break;
            }
            if (k < min_value){
                min_value = k;
            }
        }
        Console.WriteLine($"sum: {counter}");
        
        int listLength = otherInts.Count - 1;
        double average = counter/listLength;
        var result = Math.Round(average, 2, MidpointRounding.AwayFromZero);

        otherInts.Sort();

        Console.WriteLine($"average: {result}");

        Console.WriteLine($"highest number: {max_value}");

        Console.WriteLine($"lowest number: {min_value}");

        Console.WriteLine("Here's the list in order");

        sortedNumbers.Remove(0);

        //remove 0 from list so that it's not in the list of sorted numbers

        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }

    
}