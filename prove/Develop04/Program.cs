using System;

class Program
{
    static void Main(string[] args)
    {
        int continueProgram = 1;

        do{
            Console.Clear();
            Console.WriteLine("Hello!\n Welcome to the Mindfulness Program!\n Please select an option from the menu by number\nMenu:\n1) Breathing Activity\n2) Reflection Activity\n3) Listing Activity\n4) Senses Activity\n5) Quit");
        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice){
            case 1:
            BreathingActivity breathing = new BreathingActivity();
            breathing.DisplayAll();
            break;

            case 2:
            ReflectionActivity reflection = new ();
            reflection.DisplayAll();
            break;

            case 3:
            ListingActivity listing =new ();
            listing.DisplayAll();
            break;

            case 4:
            SensesActivity senses = new ();
            senses.DisplayAll();
            break;
            
            default:
            continueProgram = 4;
            break;
            }
        }
        while(continueProgram !=4);
        
        
    }
}