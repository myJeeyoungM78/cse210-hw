Date: 2/20/2024
Class: CSE 210 
Professor : Vaughn Poulson
Student: Jeeyoung Madsen

Articulate the principles of programming with classes

1. Abstraction : Simplifying complex systems, Reduces complexity, Making it easier to 
                design.

    * ex. Making to design easier each of classes.

    public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        this._name = name;
        this._text = text;
    }

    public override string ToString()
    {
        return _name + ": " + _text;
    }
}

    * Overall : Flexibility by hiding and details

2. Encapsulation : The idea is to encapsulate the internal workings of an object, 
                Hiding the detail of behaviors, Preventing other of the program from accessing those details.

    * ex. This encapsulate work of an object.

    public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }


    public bool IsUSA()
    {
        return _country.Equals("USA");
    }

    public string GetAddressDetails()
    {
        return _street + "\n" + _city + ", " + _state + "\n" + _country; 
    }
}

    * Overall : Encapsulation enhances the flexibility, modularity, information hiding, and maintainability.

3. Inheritance : The ability for one class to obtain the attributes and methods of 
                another class, A new class inherits attributes and methods from an existing class.

    ex. Class to obtain the attributes base class

    public class Lectures : Events
{
    private string _speaker;

    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + "\n" + GetEventType() + "\n" + GetSpecificDetails();
    }

    public string GetSpecificDetails()
    {
        string speaker = $"Speaker:{_speaker}";
        string cap = $"Capacity:{_capacity}";

        return speaker + "\n" + cap;
    }
}

    Overall : Inheritance is a principle in object behaviors that allows classes to inherit properties.

4. Polymorphism : Polymorphism refers to the ability of objects to take on different 
                forms, The method name stays the same but the behavior the code to run is different.

    * ex. The method name stays but the behavior code to run is other classes.

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

    * Overall : Promotes flexibility, extensibility, reduced coupling, and dynamic behavior, making it easier to accommodate changes