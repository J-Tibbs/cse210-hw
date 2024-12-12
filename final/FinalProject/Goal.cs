abstract class Goal
{
    private string _name;
    private string _desc;
    private int _points;
    private bool _isComplete = false;

    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _desc = description;
        _points = points;
    }

    public string GetName(){
        return _name;
    }
    public void SetName(string name){
        _name = name;

    }
    public string GetDesc(){
        return _desc;
    }
    public void SetDesc(string description){
        _desc = description;
    }
    public int GetPoints(){
        return _points;
    }
    public void SetPoints(int points){
        _points = points;

    }

    public bool GetStatus(){
        return _isComplete;
    }
    public void SetStatus(bool isDone){
        _isComplete = isDone;
    }
    
    public abstract string DisplayProgress();

    public abstract int CompleteItem();
}