class Menu
{
    int userChoice;
    int totalPoints;
    int totalCoins;
    List<Goal> goals = new List<Goal>();
    Game game = new Game();

    public void DisplayAll(){
        game.FirstTimeLoad();
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
            Console.WriteLine("Select a goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].DisplayProgress()}");
                    }
                    int selectedGoal = int.Parse(Console.ReadLine()) - 1;
                
                    if (selectedGoal >= 0 && selectedGoal < goals.Count)
                    {
                        int pointsEarned = goals[selectedGoal].CompleteItem();
                        Console.WriteLine($"Congrats! You earned {pointsEarned} points!");
                        totalPoints += pointsEarned;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                    // if (selectedGoal >= 0 && selectedGoal < goals.Count)
                    //     {
                    //         int pointsEarned = goals[selectedGoal].CompleteItem();
                    //         totalPoints += pointsEarned;
                    //         Console.WriteLine($"Congrats! You earned {pointsEarned} points!");
                    //     }
                break;
            case 2:
                game.SetCoins(totalCoins);
                game.SetPoints(totalPoints);
                game.DisplayAll();
                totalPoints = game.returnPoints();
                totalCoins = game.returnCoins();
                break;
            case 3:
            foreach (var goal in goals)
                {
                    Console.WriteLine(goal.DisplayProgress());
                }
                break;
            case 4:
                Console.WriteLine("Select Goal Type: 1) One Time 2) Repeated 3) Checklist");
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
                SaveAndLoad save = new SaveAndLoad(fileName, goals, game, totalPoints);
                save.SaveFile();
                break;
            case 6:
                Console.WriteLine("What file would you like to load from?");
                fileName = Console.ReadLine();
                SaveAndLoad load = new SaveAndLoad(fileName, goals, game, totalPoints);
                totalPoints = load.LoadFile();
                
                break;
        }
        }while(userChoice != 7);

    }

}