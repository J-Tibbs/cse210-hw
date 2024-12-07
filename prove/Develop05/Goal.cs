using System.ComponentModel;

abstract class Goal{
    private string _name;
    private string _desc;
    private int _points;
    private bool _isComplete = false;


    public Goal(string name, int points, string description){
        _name = name;
        _points = points;
        _desc = description;
    }

    public void SetName(string name){
        _name = name;
    }
    public string GetName(){
        return _name;
    }
    public void SetPoints(int points){
        _points = points;
    }
    public int GetPoints(){
        return _points;
    }
    public void SetDesc(string description){
        _desc = description;
    }
    public string GetDesc(){
        return _desc;
    }
    public bool Status(){
        return _isComplete;
    }
    public void isCompleted(bool done){
        _isComplete = done;
    }

    public abstract int RecordEvent();
    public abstract string DisplayProgress();

}