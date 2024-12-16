using System.Globalization;
using System.Net.Quic;
using System.Runtime.CompilerServices;

class Game
{
    private int pointAmount;
    private int coinAmount;
    private int q1Index = 0, q2Index = 1, q3Index = 2, q4Index = 3;
    private int[] q1 = [0, 1, 5, 6];
    private int[] q2 = [3, 4, 8, 9];
    private int[] q3 = [15, 16, 20, 21];
    private int[] q4 = [18, 19, 23, 24];
    List<string> farm = new List<string>();
    List<Crops> cropFarm = new List<Crops>();
    NoneCrop n = new NoneCrop(100000,-1,"Nothing");
    Wheat w = new Wheat(3, 80, "Wheat");
    Corn c = new Corn(3, 280, "Corn");
    Pumpkin p = new Pumpkin(3, 1000, "Pumpkin");
    List<Array> quadrants = new List<Array>();
    int growthStage;
    


    public Game(){}
    public Game(int points, int coins){
        pointAmount = points;
        coinAmount = coins;
    }
public void DisplayAll(){
    int userInput;

do{    

    foreach(Crops item in cropFarm){
        if (item == w){
            replaceQuadrant(w, cropFarm.IndexOf(item));
        }
        if (item == c){
            replaceQuadrant(c, cropFarm.IndexOf(item));
        }
        if (item == p){
            replaceQuadrant(p, cropFarm.IndexOf(item));
        }
        if (item == n){
            replaceQuadrant(n, cropFarm.IndexOf(item));
        }
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
    Console.WriteLine("Options: " + "\n1) Buy Wheat (750 pts)  2) Buy Corn (1,500 pts)  3) Buy Pumpkin (7,500 pts)  4) Quit");
    growthStage += 1;
    if (growthStage >= 5){
        growthStage = 0;
    }
    userInput = int.Parse(Console.ReadLine());
    
    bool bought = false;
    switch (userInput){
        case 1:
            if(pointAmount >= 750){
                foreach(Crops item in cropFarm.ToList()){
                    if(item == n && !bought){
                        cropFarm[cropFarm.IndexOf(item)] = w;
                        pointAmount -= 750;
                        bought = true;
                    }
                }
                if(!bought){
                    Console.WriteLine("There's no space left!");
                }
            }
            else{
                Console.WriteLine("Not enough points, sorry");
            }
            break;
        case 2:
        if(pointAmount >= 1500){
                foreach(Crops item in cropFarm.ToList()){
                    if(item == n && !bought){
                        cropFarm[cropFarm.IndexOf(item)] = c;
                        pointAmount -= 1500;
                        bought = true;
                    }
                }
                if(!bought){
                    Console.WriteLine("There's no space left!");
                }
            }
            else{
                Console.WriteLine("Not enough points, sorry");
            }
            break;
        case 3:
        if(pointAmount >= 7500){
                foreach(Crops item in cropFarm.ToList()){
                    if(item == n && !bought){
                        cropFarm[cropFarm.IndexOf(item)] = p;
                        pointAmount -= 7500;
                        bought = true;
                    }
                }
                if(!bought){
                    Console.WriteLine("There's no space left!");
                }
            }
            else{
                Console.WriteLine("Not enough points, sorry");
            }
            break;
    }

    for (int i = 0; i < cropFarm.Count; i++)
    {
        if (growthStage > cropFarm[i].GetGrowTime())
        {
            coinAmount += cropFarm[i].GetValue();
            cropFarm[i] = n;
        }
    }
    
}while(userInput !=4);
}

public void FirstTimeLoad(){
        farm = ["~","~","||","~","~",
                "~","~","||","~","~",
                "=","=","::","=","=",
                "~","~","||","~","~",
                "~","~","||","~","~"];
        cropFarm = [n,n,n,n];
}


public string GameSave(){
string saveFile = "";
    for(int i = 0; i < cropFarm.Count(); i++){
        if(cropFarm[i] == w){
            saveFile += "w|";

        }
        else if(cropFarm[i] == c){
            saveFile += "c|";
        }
        else if(cropFarm[i] == p){
            saveFile += "p|";
        }
        else if (ReferenceEquals(cropFarm[i], n)){
            saveFile += "n|";
        }
        
    }

        
    saveFile += $"{coinAmount}|";;



return saveFile;
}

public void LoadFile(string saveLine){
    string[] saved;
    saved = saveLine.Split("|");

    for(int i = 0; i < cropFarm.Count(); i ++){
        if (saved[i] == "n"){
            cropFarm[i] = n;
        }
        else if(saved[i] == "w"){
            cropFarm[i] = w;
        }
        else if(saved[i] == "c"){
            cropFarm[i] = c;
        }
        else if(saved[i] == "p"){
            cropFarm[i] = p;
        }

    }
    coinAmount = int.Parse(saved[4]);
}

public void SetPoints(int point){
    pointAmount = point;
}
public void SetCoins(int coin){
    coinAmount = coin;
}
public int returnPoints(){
    return pointAmount;
}
public int returnCoins(){
    return coinAmount;
}

public void replaceQuadrant(Crops crop, int quad){
    if (quad == 0){//q1
        foreach(int num in q1){
            farm[num] = crop.GetSprite();
        }
    }
    else if (quad == 1){//q2
        foreach(int num in q2){
            farm[num] = crop.GetSprite();
    }
    }
    else if (quad == 2){//q3
        foreach(int num in q3){
            farm[num] = crop.GetSprite();
    }
    }
    else if (quad == 3){//q4
        foreach(int num in q4){
            farm[num] = crop.GetSprite();
    }
    }

}


}