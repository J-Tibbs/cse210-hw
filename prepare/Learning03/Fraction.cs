using System.Runtime.CompilerServices;

class Fraction{
    private int top;
    private int bottom;
    public Fraction(){
        top = 1;
        bottom = 1;
    }
    public Fraction(int wholeNumber){
        top = wholeNumber;
        bottom = 1;
    }
    public Fraction(int numerator, int denominator){
        top = numerator;
        bottom = denominator;
        

    }

    public String GetFractionValue(){
        string fractionString = $"{top}/{bottom}";
        return fractionString;
    }
    public Double GetDecimalValue(){
        double decimalValue = (double)top/(double)bottom;
        return decimalValue;
    }

}