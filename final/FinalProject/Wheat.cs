class Wheat : Crops{

    public Wheat(int growTime, int value, string name) : base(growTime, value, name){}

    public string sprite = "ɿ|r";

    public override string GetSprite()
    {
        return sprite;
    }

}