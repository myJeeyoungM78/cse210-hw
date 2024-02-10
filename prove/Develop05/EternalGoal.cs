using System;
public class EternalGoal : Goal
{
    // public class EternalGoal : Goal
    // {
        
    // }

    public EternalGoal() : base(){this._type = "Eternal";}

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override int GetPointsForScore()
    {
        return Points;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}