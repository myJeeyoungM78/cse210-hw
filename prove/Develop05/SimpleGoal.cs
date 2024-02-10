/// <summary>
///  Simple goals that can be marked complete and the user gains some value.
///  For example, if you run a marathon you get 1000 points.
/// </summary>
public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    // List<Goal> goals;

    public SimpleGoal() : base()
    {
        this._type = "Simple";
    }

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        // goals = new List<Goal>();
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