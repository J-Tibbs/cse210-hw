class Pumpkin : Crops{

    public Pumpkin(int growTime, int value, string name) : base(growTime, value, name){}

    public string sprite = "((`))";

    public override string GetSprite()
    {
        return sprite;
    }
}