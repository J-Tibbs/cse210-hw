class ChecklistGoal : Goal
{
    public int TargetCount;
    public int CurrentCount;
    public int BonusPoints;

    public ChecklistGoal(string name, int points, string description, int targetCount, int bonusPoints)
        : base(name, points, description)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!Status())
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                isCompleted(true);
                return GetPoints() + BonusPoints;
            }
            return GetPoints();
        }
        return 0;
    }

    public override string DisplayProgress()
    {
        return $"[ {(Status() ? "X" : " ")} ] {GetName()} (Completed {CurrentCount}/{TargetCount})";
    }
}
