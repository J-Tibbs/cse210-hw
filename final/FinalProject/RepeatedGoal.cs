class RepeatedGoal : Goal
{
    public RepeatedGoal(string name, string description, int points) : base (name, description, points) {}



    public override string DisplayProgress(){
        return "Repeated";
    }

    public override int CompleteItem(){
        return 1;
    }
}