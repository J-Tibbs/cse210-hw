using System.Runtime.CompilerServices;

class SensesActivity : Activities{


    public void DisplayAll(){
        Console.WriteLine("Welcome to the Senses Activity.");
        Console.WriteLine("During this activity, you will be asked about your different senses. Answer based on what you experience around you.");
        Console.WriteLine("Get Ready");
        LoadingAnim(5);
        Console.Clear();

        Console.WriteLine("What are 5 things you can see?");

        int i = 0;

        while(i < 5){
            Console.Write("=>");
            Console.ReadLine();
            i++;
        }
        LoadingAnim(2);
        Console.WriteLine("\nWhat are 4 things you can feel?");

        i = 0;

        while(i < 4){
            Console.Write("=>");
            Console.ReadLine();
            i++;
        }
        LoadingAnim(2);
        Console.WriteLine("\nWhat are 3 things you can hear?");

        i = 0;

        while(i < 3){
            Console.Write("=>");
            Console.ReadLine();
            i++;
        }
        LoadingAnim(2);
        Console.WriteLine("\nWhat are 2 things you can smell?");

        i = 0;

        while(i < 2){
            Console.Write("=>");
            Console.ReadLine();
            i++;
        }
        LoadingAnim(2);
        Console.WriteLine("\nWhat is 1 thing you can taste?");

        i = 0;

        while(i < 1){
            Console.Write("=>");
            Console.ReadLine();
            i++;
        }
        LoadingAnim(2);

        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed the Senses Activity.");
        LoadingAnim(5);
        }

}