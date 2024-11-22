class Word{
    private string word;
    private bool _shown;
    public Word(string text){
        word = text;
        _shown = true;

    }

    public void HideWord(){
        if(_shown){
            Random rnd = new Random();
            if(rnd.Next(1,11) == 10){
                _shown = false;
            }
        }
    }

    public void Display(){
        Console.Write(word);
    }

    public bool IsShown(){
        return _shown;
    }

    public string GetWord(){
        return word;
    }


}

    
