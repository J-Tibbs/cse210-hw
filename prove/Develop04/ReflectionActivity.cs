class ReflectionActivity : Activities{
    public ReflectionActivity(){

    }
    private List<string> Prompts = [
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
];

    private List<string> Questions = [
        
    "Why was this experience meaningful to you?",
    " Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"

    ];

public void DisplayAll(){
        Console.WriteLine($"Welcome to the Reflection Activity.");
        Console.WriteLine("How long would you like to do this activity for?");
        int seconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready");
        LoadingAnim(5);
        Console.Clear();

        Console.WriteLine($"Prompt: {ChoosePrompt()}");
        DateTime finishTime = DateTime.Now.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        
        while(currentTime < finishTime){
            currentTime = DateTime.Now;
            Console.WriteLine(ChooseQuestion());
            Console.Write("=>");
            Console.ReadLine();
            LoadingAnim(2);

        }
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {seconds} seconds of the Breathing Activity.");
        LoadingAnim(5);
}

public string ChoosePrompt(){
    Random rnd = new();
    return Prompts[rnd.Next(0,Prompts.Count()-1)];
}
public string ChooseQuestion(){
    Random rnd = new();
    return Questions[rnd.Next(0, Questions.Count()-1)];
}
}