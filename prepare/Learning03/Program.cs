using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var car = new Car("Honda","Civic");

        car.PrintDetails();

        car.SetMake("Ford");
        car.Year = 1999;

        var fraction = new Fraction();
        var fraction1 = new Fraction(5);
        //var fraction2 = new Fraction(6,1);

        //fraction.SetTopValue(3);
        //fraction.SetBottomValue(1);
        //int top = fraction.GetTopValue();
        //int bottom = fraction.GetBottomValue();
        //Console.WriteLine($"{top} {bottom}");
        fraction.GetFractionString();
        double result = fraction.GetDecimalValue();
        Console.WriteLine(result);

        fraction1.GetFractionString();
        double result1 = fraction1.GetDecimalValue();
        Console.WriteLine(result1);

        var fraction2 = new Fraction(3,4);
        fraction2.GetFractionString();
        double result2 = fraction2.GetDecimalValue();
        Console.WriteLine(result2);

        var fraction3 = new Fraction(1,3);
        fraction3.GetFractionString();
        double result3 = fraction3.GetDecimalValue();
        Console.WriteLine(result3);
    }
}