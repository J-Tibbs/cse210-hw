using System.IO.Enumeration;

class SaveAndLoad
{
    private string _fileName;
    List<Goal> goals = new List<Goal>();
    List<string> gameSave = new List<string>();
    public SaveAndLoad(string fileName, List<Goal> list){
        _fileName = fileName;
        goals = list;
    }

    public void SaveFile(){
        Game game = new Game();

        gameSave = game.GameSave();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
        foreach (var goal in goals)
        {
            if (goal is OneTimeGoal)
            {
                outputFile.WriteLine($"SimpleGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}|{goal.GetStatus()}");
            }
            else if (goal is RepeatedGoal)
            {
                outputFile.WriteLine($"EternalGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}");
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                outputFile.WriteLine($"ChecklistGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}|{checklistGoal.TargetCount}|{checklistGoal.CurrentCount}|{checklistGoal.BonusPoints}|{goal.GetStatus()}");
            }
        }
    }
    }
    public void LoadFile(){
        
    }
    
}