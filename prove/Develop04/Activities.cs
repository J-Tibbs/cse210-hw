class Activities{
    
        public bool countdownEnd = false;


    public Activities(){

    }


    public void LoadingAnim(int seconds){
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        List<String> spinner = new List<string>();
        spinner = ["-","\\","|","/"];
        int position = 0;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write($"{spinner[position]}");
            position ++;
            if (position > spinner.Count()-1){
                position = 0;
            } 
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
        
    }





}