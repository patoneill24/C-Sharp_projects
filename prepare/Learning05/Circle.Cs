public class Circle : Shape{
    private int radius;
    public Circle(int radius, string color): base(color){
        this.radius= radius;
    }

    public override double GetArea()
    {
        return Math.PI*Math.Pow(radius,2);
    }
}