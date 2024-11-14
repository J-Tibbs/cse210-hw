using System;

class Program
{
    static void Main(string[] args)
    {
    Journal journal = new Journal();
    int userChoice;
    string menu = "Please select an option (1-5):"
    +"\n1) Write"
    +"\n2) Display"
    +"\n3) Save"
    +"\n4) Load"
    +"\n5) Quit";
    bool quit = false;

    while(!quit){
        Console.WriteLine(menu);
        userChoice = int.Parse(Console.ReadLine());

        if(userChoice == 5){
            quit = true;
        }
        else if(userChoice == 4){
            journal.LoadFile();
        }
        else if(userChoice == 3){
            journal.SaveFile();
        }
        else if(userChoice == 2){
            journal.Display();
        }
        else if (userChoice == 1){
            journal.AddEntry();
        }

    }
    }
}