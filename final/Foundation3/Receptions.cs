
public class Receptions : Events
{
    private string _email;

    public Receptions(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        this._email = email;
    }

    public override string GetEventType()
    {
        return "Reception";
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + "\n" + GetEventType() + "\n" + GetSpecficDetails();
    }

    public string GetSpecficDetails()
    {
        return $"RSVP Email: {_email}";
    }
}