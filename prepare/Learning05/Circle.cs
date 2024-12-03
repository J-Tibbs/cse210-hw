class Circle : Shape{

private double radius;

public Circle(string color, double _radius) : base(color){
    radius = _radius;
}

public override double GetArea(){
    return radius *= Math.PI * radius;
}
}