class BreathingActivity : Activities{

    
    public void DisplayAll(){
        Console.WriteLine($"Welcome to the Breathing Activity.");
        Console.WriteLine("How long would you like to do this activity for?");
        int seconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready");
        LoadingAnim(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            currentTime = DateTime.Now;
            Breathing();
            
        }
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {seconds} seconds of the Breathing Activity.");
        LoadingAnim(5);
    }

    public void Breathing(){
        DateTime startBreath = DateTime.Now;
        DateTime endBreath = startBreath.AddSeconds(4);
        int breathingTimer = 4;
        Console.Write($"\bInhale: {breathingTimer}");
    while (breathingTimer > 0){
        Console.Write($"\b{breathingTimer}");
        breathingTimer--;
        Thread.Sleep(1000);
        }
        Console.Write("\b\b");
        breathingTimer = 4;
        Console.WriteLine("");
        Console.Write($"\bExhale: {breathingTimer}");
    while (breathingTimer > 0){
        Console.Write($"\b{breathingTimer}");
        breathingTimer--;
        Thread.Sleep(1000);
        }
        Console.Write("\b\b");
        Console.WriteLine("");
            

    }
}