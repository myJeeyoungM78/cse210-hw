/// <summary>
///  A checklist goal must be accomplished a certain number of times to be complete. 
///  Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
/// </summary>
public class ChecklistGoal : Goal
{

    /// <summary>
    /// How many times the goal has been completed.
    /// This should always start at 0
    /// </summary>
    private int _amountCompleted = 0;

    /// <summary>
    /// The desired number of times to 
    /// </summary>
    private int _target;

    /// <summary>
    /// Bouns points for achiveing the goal target
    /// </summary>
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        this._target = target;
        this._bonus = bonus;
        base._type = "Check List";
    }

    public ChecklistGoal() : base(){base._type = "Check List";}

    public override string GetDetailsString()
    {
        string details = base.ToString() + $" times completed:{_amountCompleted}";
        return details;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override void RecordEvent()
    {
        this._amountCompleted++;
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