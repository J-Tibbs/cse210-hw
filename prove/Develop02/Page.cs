using System.Runtime.CompilerServices;

class Page{
    Random rnd = new Random();
    
    private string prompt;
    private DateTime theCurrentTime = DateTime.Now;
    private string dateText;
    private string writings;
    private List<string> promptsList = ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What was the most interesting part of the day?",
    "What was the best thing I ate today?",
    "What was the worst thing to happen today?"];

    public Page(){
        dateText = theCurrentTime.ToShortDateString();
    }

    public string ChoosePrompt(){
        int randomNum = rnd.Next(0,promptsList.Count());
        prompt = promptsList[randomNum];
        return prompt;
    }

    public string createEntry(){
        string entry;
        Console.WriteLine(ChoosePrompt());
        Console.Write("=>");
        writings = Console.ReadLine();
        entry = $"{dateText} \n {prompt}: \n {writings}";
        return entry;
    }
}
