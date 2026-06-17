public class Rectangle : Shape
{
    private double _base;
    private double _height;

    public Rectangle(string color, double x, double y) : base(color)
    {
        _base = x;
        _height = y;
    }

    public override double GetArea()
    {
        return _base * _height;
    }
}