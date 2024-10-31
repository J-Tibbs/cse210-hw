using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int sqrdNum = SquareNumber(favoriteNum);
        DisplayResult(name, sqrdNum);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("What is your name? ");
        string usersName = Console.ReadLine();
        return usersName;
    }
    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int favNum){
        favNum *= favNum;
        return favNum;
    }
    static void DisplayResult(string name, int squared){
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}