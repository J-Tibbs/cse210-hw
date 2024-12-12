using System.Globalization;

class Game
{
    private int pointAmount;
    private int coinAmount;
    private bool firstTime = true;
    private int q1Index = 0, q2Index = 1, q3Index = 2, q4Index = 3;
    List<string> farm = new List<string>();
    List<Crops> cropFarm = new List<Crops>();
    NoneCrop n = new NoneCrop(-1,-1,"Nothing");
    Wheat w = new Wheat(3, 20, "Wheat");
    Corn c = new Corn(6, 70, "Corn");
    Pumpkin p = new Pumpkin(12, 160, "Pumpkin");


    public Game(){}
    public Game(int points, int coins){
        pointAmount = points;
        coinAmount = coins;
    }
public void DisplayAll(){
    if(firstTime){
        FirstTimeLoad();
        firstTime = false;
    }
    
    int j = 0;
    Console.WriteLine($"{pointAmount}     {coinAmount}");
    for(int i = 0; i < 5; i++){
        for(int h = 0; h<5; h++){
                Console.Write(farm[j]);
                j++;
            }
            Console.WriteLine();
        }
    Console.WriteLine("Options: " + "\n1) Buy Wheat (20 pts)  2) Buy Corn ()  3) Buy Pumpkin ()  4) Quit");
    int userInput = int.Parse(Console.ReadLine());
    switch (userInput){
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
    }
}

public void FirstTimeLoad(){
        farm = ["c","c","||","c","c",
                "c","c","||","c","c",
                "=","=","::","=","=",
                "c","c","||","c","c",
                "c","c","||","c","c"];
                Path p = new Path(-1,-1,"Path");
        cropFarm = [n,n,n,n];
}


public List<string> GameSave(){
List<string> saveFile = new List<string>();
    for(int i = 0; i < cropFarm.Count(); i++){
        if(cropFarm[i] == w){
            saveFile.Add("w|");

        }
        else if(cropFarm[i] == c){
            saveFile.Add("c|");
        }
        else if(cropFarm[i] == p){
            saveFile.Add("p|");
        }
        else{
            saveFile.Add("n|");
        }
    }
    saveFile.Add($"{coinAmount}");


return saveFile;
}
}