using System;
using System.Diagnostics.Contracts;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int userChoice;
        int totalPoints = 0;
        do{
            Console.WriteLine($"\nYour total points: {totalPoints}\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1) Create New Goal"
            + "\n2) List Goals"
            +"\n3) Save Goals"
            +"\n4) Load Goals"
            + "\n5) Record Event"
            +"\n6) Quit");
            userChoice = int.Parse(Console.ReadLine());

            switch(userChoice){
                case 1:
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
                            goals.Add(new SimpleGoal(name, points, description));
                            break;
                        case 2:
                            goals.Add(new EternalGoal(name, points, description));
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

                case 2:
                foreach (var goal in goals)
                    {
                        Console.WriteLine(goal.DisplayProgress());
                    }
                    break;
                case 3:
                    Console.WriteLine("Which file would you like to save the goals to?");
                    string fileName = Console.ReadLine();
                    SaveAndLoad save = new(fileName, goals);
                    save.SaveGoals();
                    break;
                case 4:
                    Console.WriteLine("Which file would you like to load the goals from?");
                    String loadFileName = Console.ReadLine();
                    SaveAndLoad load = new(loadFileName, goals);
                    load.LoadGoals();
                break;
                case 5:
                    Console.WriteLine("Select a goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].DisplayProgress()}");
                    }
                    int selectedGoal = int.Parse(Console.ReadLine()) - 1;
                
                    if (selectedGoal >= 0 && selectedGoal < goals.Count)
                    {
                        int pointsEarned = goals[selectedGoal].RecordEvent();
                        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                    if (selectedGoal >= 0 && selectedGoal < goals.Count)
                        {
                            int pointsEarned = goals[selectedGoal].RecordEvent();
                            totalPoints += pointsEarned; // Add earned points to the total.
                            Console.WriteLine($"Event recorded! You earned {pointsEarned} points. Total points: {totalPoints}");
                        }
                    break;
                
            }
        }while(userChoice != 6);

        

    }


}