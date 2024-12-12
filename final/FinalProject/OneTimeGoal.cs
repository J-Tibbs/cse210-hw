class OneTimeGoal : Goal
{
    public OneTimeGoal(string name, string description, int points) : base (name, description, points) {}

    public override string DisplayProgress(){

        return $"[ {(GetStatus() ? "X" : " ")} ] {GetName()}: {GetDesc()}";
    }

    public override int CompleteItem(){
        if (!GetStatus()){
            SetStatus(true);
            return GetPoints();
        }
        else{
        return 0;
        }
    }
}