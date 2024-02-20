
public class Running : Activity
{
    private double _distance;
    public Running(double distance, DateTime date, int minutes) : base (date, minutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        System.Console.WriteLine($"Running spped = D{_distance} / M{GetMinutes()}");
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }


    public override string GetType()
    {
        return "Running ";
    }




}