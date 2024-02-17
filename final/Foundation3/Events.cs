
public abstract class Events
{
    private string _title = " ";
    private string _description = " ";
    private string _date;
    private string _time;
    private Address _address;


    public Events(string title, string description, string date, string time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return _title + " : " + _description + "\n" + _date + " at " + _time + "\n" + _address.GetAddressDetails();
    }

    public abstract string GetFullDetails();
    public abstract string GetEventType();
    public string GetShortDescription()
    {
        return GetEventType() + "\n" + _title + "\n" + _date + "\n";
    }
}