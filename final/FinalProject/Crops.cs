abstract class Crops{
    private int _growTime;
    private int _value;
    private string _name;

public Crops(int growTime, int value, string name){
    _growTime = growTime;
    _value = value;
    _name = name;
}

public int GetGrowTime(){
    return _growTime;
}
public void SetGrowTime(int growTime){
    _growTime = growTime;
}
public int GetValue(){
    return _value;
}
public void SetValue(int value){
    _value = value;
}
public string GetName(){
    return _name;
}
public void SetName(string name){
    _name = name;
}
public abstract string GetSprite();
}