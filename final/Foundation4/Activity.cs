using System.Data;
using System.Data.Common;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        this._minutes = minutes;
        this._date = date;
    }

    public int GetMinutes()
    {
        return this._minutes;
    }

    public virtual double GetDistance()
    {
        return (0);   
    }

    public virtual double GetSpeed()
    {
        return (0);
    }

    public virtual double GetPace()
    {
        return (0);
    }

    public string GetSummary()
    {
        return _date.ToString("dd MMM yyyy") + " " + GetType() + $" ({_minutes} min)- Distance {GetDistance().ToString("0.00")} miles, Speed {GetSpeed().ToString("0.00")} mph, Pace: {GetPace().ToString("0.00")} min per mile";
    }

    public virtual string GetType()
    {
        return "";
    }
}