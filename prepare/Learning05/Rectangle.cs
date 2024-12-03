class Rectangle : Shape{

private double length;
private double width;

public Rectangle(string color, double _length, double _width) : base(color){
    length = _length;
    width = _width;
}

public override double GetArea(){
    return length *= width;
}
}