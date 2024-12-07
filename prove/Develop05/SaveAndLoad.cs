class SaveAndLoad{
    private string _fileName;
    List<Goal> goals = new List<Goal>();
    public SaveAndLoad(string fileName, List<Goal> listOfGoals){
        _fileName = fileName;
        goals = listOfGoals;
    }
    public void SaveGoals()
{
    using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
        foreach (var goal in goals)
        {
            if (goal is SimpleGoal)
            {
                outputFile.WriteLine($"SimpleGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}|{goal.Status()}");
            }
            else if (goal is EternalGoal)
            {
                outputFile.WriteLine($"EternalGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}");
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                outputFile.WriteLine($"ChecklistGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}|{checklistGoal.TargetCount}|{checklistGoal.CurrentCount}|{checklistGoal.BonusPoints}|{goal.Status()}");
            }
        }
    }
}

    public void LoadGoals()
{
    goals.Clear(); // Clear the current list of goals
    string[] lines = File.ReadAllLines(_fileName);

    foreach (string line in lines)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        string name = parts[1];
        int points = int.Parse(parts[2]);
        string description = parts[3];

        switch (type)
        {
            case "SimpleGoal":
                bool isSimpleComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(name, points, description);
                simpleGoal.isCompleted(isSimpleComplete);
                goals.Add(simpleGoal);
                break;

            case "EternalGoal":
                EternalGoal eternalGoal = new EternalGoal(name, points, description);
                goals.Add(eternalGoal);
                break;

            case "ChecklistGoal":
                int targetCount = int.Parse(parts[4]);
                int currentCount = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);
                bool isChecklistComplete = bool.Parse(parts[7]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, points, description, targetCount, bonusPoints)
                {
                    CurrentCount = currentCount
                };
                checklistGoal.isCompleted(isChecklistComplete);
                goals.Add(checklistGoal);
                break;

            default:
                Console.WriteLine($"Unknown goal type: {type}");
                break;
        }
    }

    Console.WriteLine("Goals loaded successfully!");
}

}