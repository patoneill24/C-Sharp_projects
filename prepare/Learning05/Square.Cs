public class Square : Shape{
    private int side;
    public override double GetArea()
    {
        return side * side;
    }

    public Square(int side, string color): base(color){
        this.side = side;
    }
}