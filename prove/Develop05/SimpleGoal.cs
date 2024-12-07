class SimpleGoal : Goal
{
    public SimpleGoal(string name, int point, string description) : base(name, point, description) { }

    public override int RecordEvent()
    {
        if (!Status())
        {
            isCompleted(true);
            return GetPoints();
        }
        return 0;
    }

    public override string DisplayProgress()
    {
        return $"[ {(Status() ? "X" : " ")} ] {GetName()}: {GetDesc()}";
    }
}
