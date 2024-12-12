class Menu
{
    int userChoice;
    int totalPoints;
    List<Goal> goals = new List<Goal>();

    public void DisplayAll(){
        do{
        Console.WriteLine($"\nYour total points: {totalPoints}\n");
        Console.WriteLine("Please select an option by number:");
        Console.WriteLine("1) Complete Task");
        Console.WriteLine("2) Visit Farm");
        Console.WriteLine("3) List Tasks");
        Console.WriteLine("4) Add Task");
        Console.WriteLine("5) Save List");
        Console.WriteLine("6) Load List");
        Console.WriteLine("7) Quit");
        userChoice = int.Parse(Console.ReadLine());
        switch(userChoice){
            case 1:
                break;
            case 2:
                Game game = new Game(totalPoints, 0);
                game.DisplayAll();
                break;
            case 3:
            foreach (var goal in goals)
                {
                    Console.WriteLine(goal.DisplayProgress());
                }
                break;
            case 4:
                Console.WriteLine("Select Goal Type: 1) Simple 2) Eternal 3) Checklist");
                    int goalType = int.Parse(Console.ReadLine());
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case 1:
                            goals.Add(new OneTimeGoal(name, description, points));
                            break;
                        case 2:
                            goals.Add(new OneTimeGoal(name, description, points));
                            break;
                        case 3:
                            Console.Write("Enter target count: ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.Write("Enter bonus points: ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            goals.Add(new ChecklistGoal(name, points, description, targetCount, bonusPoints));
                            break;
                    }
                    Console.WriteLine("Goal created successfully!");
                    break;
            case 5:
                Console.WriteLine("What file would you like to save to");
                string fileName = Console.ReadLine();
                SaveAndLoad save = new SaveAndLoad(fileName, goals);
                save.SaveFile();
                break;
            case 6:
                Console.WriteLine("What file would you like to load from?");
                fileName = Console.ReadLine();
                SaveAndLoad load = new SaveAndLoad(fileName, goals);
                load.LoadFile();
                break;
        }
        }while(userChoice != 7);

    }

}