class ChecklistGoal : Goal
{
    public int TargetCount;
    public int CurrentCount;
    public int BonusPoints;

    public ChecklistGoal(string name, int points, string description, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override int CompleteItem()
    {
        if (!GetStatus())
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                SetStatus(true);
                return GetPoints() + BonusPoints;
            }
            return GetPoints();
        }
        return 0;
    }

    public override string DisplayProgress()
    {
        return $"[ {(GetStatus() ? "X" : " ")} ] {GetName()} (Completed {CurrentCount}/{TargetCount})";
    }
}
