class EternalGoal : Goal
{
    public EternalGoal(string name, int points, string description) : base(name, points, description) { }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string DisplayProgress()
    {
        return $"[ ] {GetName()}: {GetDesc()} (Eternal)";
    }
}
