using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade as a number? ");
        int numbGrade = int.Parse(Console.ReadLine());
        string grade;
        string addOn = "";
        if (numbGrade >= 90){
            grade = "A";
        }
        else if (numbGrade >= 80){
            grade = "B";
        }
        else if(numbGrade >=70){
            grade = "C";
        }
        else if(numbGrade >= 60){
            grade = "D";
        }
        else{
            grade = "F";
        }
        if (grade == "B" || grade == "C" || grade == "D"){
            int remainder = numbGrade % 10;
            if (remainder >=7){
                addOn = "+";
            }
            else if (remainder < 3){
                addOn = "-";
            }
            else {
                addOn = "";
            }
        }
        else if (grade == "A"){
            int remainder = numbGrade % 10;

            if (remainder < 3){
                addOn = "-";
            }
        }
        
        
        Console.WriteLine($"You have a {grade}{addOn}");
        if(numbGrade >= 70){
            Console.WriteLine("You pass this class!");
        }
        else{
            Console.WriteLine("Better luck next time");
        }
    }
}