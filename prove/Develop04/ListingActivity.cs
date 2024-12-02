class ListingActivity : Activities{

    private List<string> Prompts = [
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "Who are people that have helped you this week?"

    ];

    public ListingActivity(){}

    public void DisplayAll(){
        Console.WriteLine($"Welcome to the Listing Activity.");
        Console.WriteLine("How long would you like to do this activity for?");
        int seconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready");
        LoadingAnim(5);
        Console.Clear();

        Random rnd = new Random();
        Console.WriteLine($"Prompt: {Prompts[rnd.Next(0,Prompts.Count - 1)]}");
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        while(currentTime < endTime){
            currentTime = DateTime.Now;
            Console.Write("=>");
            Console.ReadLine();
        }



        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {seconds} seconds of the Breathing Activity.");
        LoadingAnim(5);
    }
}