class Settings{
    public Settings(){

    }

    public int chooseRandom(){
        Console.WriteLine("Please input how many numbers you would like hidden each iteration:(Default is 3)");
        int randomNumber = int.Parse(Console.ReadLine());
        return randomNumber;
    }
}