using System;
using System.ComponentModel;

public abstract class Goal
{
    private string _name;
    private string _description;
    // private string _points = "";
    private int _points = 0;
    protected string _type;

    // List<string> _name;
    // List<string> _description;
    // List<string> _points;

    public Goal(){}

    public Goal(string entry)
    {
        string[] items = entry.Split(",");
        _name = items[0];
        _description = items[1];
        _points = int.Parse(items[2]);
    }
    public Goal(string name, string description, int points)
    {
        // _name = new List<string>();
        // _description = new List<string>();
        // _points = new List<string>();

        this._name = name;
        this._description = description;
        this._points = points;

        // System.Console.WriteLine($"What is name of your goal? {_name}");
        // System.Console.WriteLine($"What is a short description of it? {_description}");
        // System.Console.WriteLine($"What is the amount of points associated with this goal? {_points}");

    }

    public override string ToString()
    {
        // return _name + " " + _description + "\n" + _points + "\n\n";
        return _name + " " + _description;

    }

    /// <summary>
    /// This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    /// </summary>
    public abstract void RecordEvent();

    /// <summary>
    /// This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    /// </summary>
    /// <returns>bool</returns>
    public abstract bool IsComplete();
    
    /// <summary>
    /// This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. 
    /// </summary>
    /// <returns>string</returns>
    public abstract string GetDetailsString();

    /// <summary>
    /// This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    /// </summary>
    /// <returns>string</returns>
    public abstract string GetStringRepresentation();

    public abstract int GetPointsForScore();

    public string Name {get; set;}
    public string Description {get; set;}
    public int Points {get; set;}
    public string Type {get; set;}
}