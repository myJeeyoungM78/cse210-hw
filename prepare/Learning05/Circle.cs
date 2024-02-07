using System.Security.Cryptography.X509Certificates;

public class Circle : Shape
{
    private double _redius;

    public Circle(string color, double redius) : base (color)
    {
        _redius = redius;

    }

    public override double GetArea()
    {
        return _redius * _redius * Math.PI;
    }
}