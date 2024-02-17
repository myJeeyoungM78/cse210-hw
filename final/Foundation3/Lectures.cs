using System;

public class Lectures : Events
{
    private string _speaker;

    /// <summary>
    /// This is the limit on how many people may attend.
    /// </summary>
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