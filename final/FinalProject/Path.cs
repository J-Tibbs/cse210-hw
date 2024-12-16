class Path : Crops{

    public Path(int growTime, int value, string name) : base(growTime, value, name){}
    string sprite = "";
    public override string GetSprite()
    {
        return sprite;
    }
}