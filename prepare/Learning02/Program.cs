namespace Learning02;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        var cars = new List<Car>();

        int count = 23;
        var car = new Car();
        car.model = "Civic";
        car.make = "Honda";
        car.gallons = 10;
        car.milesPerGallon = 30;

        var owner = new Person();
        owner.name = "bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);

        car = new Car();
        car.model = "F-150";
        car.make = "Ford";
        car.gallons = 30;
        car.milesPerGallon = 5;

        owner = new Person();
        owner.name = "Sue";
        owner.phone = "444-4444";
        car.owner = owner;

        cars.Add(car);



        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "microsoft";
        job1._startYear = 2012;
        job1._endYear = 2016;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "apple";
        job2._startYear = 2017;
        job2._endYear = 2022;

        var myResume = new Resume();
        myResume._name = "Patrick O'Neill";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();


        Console.Clear();

        foreach (var c in cars)
        {
            //System.Console.WriteLine($"{c.model}s are made by {c.make} and have {c.gallons} gallons and have {c.milesPerGallon} mpg. Therefore has a total range of {c.TotalRange()}.");
            c.Display();
        }
    }
}

//class names have an uppercase 
