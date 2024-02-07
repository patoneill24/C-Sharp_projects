class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public int GetTopValue(){
        return _top;
    }
    public int GetBottomValue(){
        return _bottom;
    }
    public void SetTopValue(int top){
        _top = top;
    }
    public void SetBottomValue(int bottom){
        _bottom = bottom;
    }
    public void GetFractionString(){
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public double GetDecimalValue(){
        return (double)_top/(double)_bottom;
    }
}
