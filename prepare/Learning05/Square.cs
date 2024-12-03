class Square : Shape{

private double sideLength;

public Square(string color, double _sideLength) : base(color){
    sideLength = _sideLength;
}

public override double GetArea(){
    return sideLength *= sideLength;
}
}