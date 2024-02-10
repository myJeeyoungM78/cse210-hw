Date: 2/10/2024
Class: CSE 210
Professor: Vaughn Poulson
Student: Jeeyoung Madsen

articulate the principle of polymorphism

* Method overriding is the ability of a child class to override
    change the behavior
* The method name stays the same but the behavior
    the code to run is different
* It involves having multiple methods with the same name but different parameter lists within the same class.
* It involves having a method in a superclass and one or more methods with the same signature
    1. Code Reusability
    2. Flexibility and Extensibility
    3. Encapsulation
    4. Reduced Complexity

* Polymorphism refers to the ability of objects to take on different forms or behaviors depending on their context.

* One key benefit of polymorphism is code reusability.
* As changes to one part of the codebase can be made without affecting other parts.

* An application of polymorphism can be found in graphical user interface (GUI) programming.


using System;
using System.ComponentModel;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points = 0;
    protected string _type;

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
        this._name = name;
        this._description = description;
        this._points = points;
    }

    public override string ToString()
    {
        return _name + " " + _description;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

    public abstract int GetPointsForScore();

    public string Name {get; set;}
    public string Description {get; set;}
    public int Points {get; set;}
    public string Type {get; set;}
}

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal() : base()
    {
        this._type = "Simple";
    }

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        this._type = "Simple";
    }

    public override void RecordEvent()
    {
        System.Console.WriteLine($"Event recorded for {this.GetDetailsString()}");
        this._isComplete = true;
    }

    public override bool IsComplete()
    {
        
        return this._isComplete;
    }

    public override string GetStringRepresentation()
    {
        string filestring = string.Join(',', Type, Name, Description, Points.ToString(), _isComplete);   
        return filestring;
    }

    public override string GetDetailsString()
    {
        string rtn = "[" + (IsComplete()? "X":" ") + "] " + Name + " " + Description;

        return rtn;
    }

    public override int GetPointsForScore()
    {
        int points = 0;

        if (IsComplete())
        {
            points = Points;
        }

        return points;
    }
}