public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetType()
    {
        return "Cycling ";
    }

    public override double GetDistance()
    {
        return GetMinutes() * _speed / 60;
    }
}