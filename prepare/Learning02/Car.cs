namespace Learning02;
class Car 
{
    public string model;
    public string make;
    public int year = 2021;
    public int milesPerGallon;
    public int gallons;
    public Person owner;

 

    public int TotalRange() {
        return gallons * milesPerGallon;
    }

    public void Display(){
        System.Console.WriteLine($"{make} {model} {year} Owner: {owner.DisplayString()}: total range = {TotalRange()} miles.");
    }
}

