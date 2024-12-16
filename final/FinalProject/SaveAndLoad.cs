using System.IO.Enumeration;
using System.Linq;

class SaveAndLoad
{
    private string _fileName;
    List<Goal> goals = new List<Goal>();
    string gameSave;
    int pointsToSaveAndLoad;

    Game game;

    //Game game = new Game();

    public SaveAndLoad(string fileName, List<Goal> list, Game _game, int point){
        _fileName = fileName;
        goals = list;
        game = _game;
        pointsToSaveAndLoad = point;
    }

    public void SaveFile(){

        gameSave = game.GameSave();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
        outputFile.WriteLine(pointsToSaveAndLoad);
        outputFile.WriteLine(gameSave);
        foreach (var goal in goals)
        {
            if (goal is OneTimeGoal)
            {
                outputFile.WriteLine($"OneTimeGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}|{goal.GetStatus()}");
            }
            else if (goal is RepeatedGoal)
            {
                outputFile.WriteLine($"RepeatedGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}");
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                outputFile.WriteLine($"ChecklistGoal|{goal.GetName()}|{goal.GetPoints()}|{goal.GetDesc()}|{checklistGoal.TargetCount}|{checklistGoal.CurrentCount}|{checklistGoal.BonusPoints}|{goal.GetStatus()}");
            }
        }
    }
    }
    public int LoadFile(){
    goals.Clear();
    string[] lines = File.ReadAllLines(_fileName);
    int pointsOnLineOne = int.Parse(lines[0]);
    game.LoadFile(lines[1]);
    lines = lines.Skip(2).ToArray();


    foreach (string line in lines)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        string name = parts[1];
        int points = int.Parse(parts[2]);
        string description = parts[3];

        switch (type)
        {
            case "OneTimeGoal":
                bool isSimpleComplete = bool.Parse(parts[4]);
                OneTimeGoal oneTimeGoal = new OneTimeGoal(name,description, points);
                oneTimeGoal.SetStatus(isSimpleComplete);
                goals.Add(oneTimeGoal);
                break;

            case "RepeatedGoal":
                RepeatedGoal repeatedGoal = new RepeatedGoal(name,description, points);
                goals.Add(repeatedGoal);
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
                checklistGoal.SetStatus(isChecklistComplete);
                goals.Add(checklistGoal);
                break;

            default:
                Console.WriteLine($"Unknown goal type: {type}");
                break;
        }
    }
    
    Console.WriteLine("Goals loaded successfully!");
    return pointsOnLineOne;
    }
    
}