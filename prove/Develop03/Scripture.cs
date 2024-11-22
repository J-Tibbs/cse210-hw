using System.ComponentModel.DataAnnotations;

class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
    _reference = reference;
    _words = new List<Word>();

    foreach (string splitWord in text.Split(" "))
    {
        Word newWord = new Word(splitWord);
        _words.Add(newWord);
    }
    }

    
    public void Display(){
        Console.Write($"{_reference.Display()} - ");
        foreach (Word word in _words){
            if(word.IsShown()){
                word.Display();
            }
            else{
                for (int i=0; i < word.GetWord().Length; i++)
                {
                    Console.Write("_");
                }
            }
                Console.Write(" ");
        }
    }

    public void HideWord(){
        bool oneHid = false;
        while(!oneHid)
        {
            foreach (Word word in _words)
            {
                if(word.IsShown())
                {
                    word.HideWord();
                    if(!word.IsShown())
                        oneHid = true;
                }
            }
        }
    }


    public bool IsHidden()
    {
        foreach(Word word in _words)
        {
            if(word.IsShown())
                return false;
        }
        return true;
    }





}