
public class Outdoorgatherings : Events
{
    private string _weather;

    public Outdoorgatherings(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        this._weather = weather;
    }

    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }

    public override string GetFullDetails()
    {
       return GetStandardDetails() + "\n" + GetEventType() + "\n" + GetSpecficDetails();
    }

    public string GetSpecficDetails()
    {
        return $"Weather Details: {_weather}";
    }
}