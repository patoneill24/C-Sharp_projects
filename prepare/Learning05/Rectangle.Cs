class Rectangle: Shape{
    private int length;
    private int width;
    public Rectangle(int length, int width, string color): base(color){
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length*width;
    }
}