class RepeatedGoal : Goal
{
    public RepeatedGoal(string name, string description, int points) : base (name, description, points) {}



    public override int CompleteItem()
    {
        return GetPoints();
    }

    public override string DisplayProgress()
    {
        return $"[ ] {GetName()}: {GetDesc()} (Eternal)";
    }
}