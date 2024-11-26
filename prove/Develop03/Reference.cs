using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _endVerse;
    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = $"-{endVerse}";
    }

    public string Display(){
        string fullReference = $"{_book} {_chapter}:{_verse}{_endVerse}";
        return fullReference;
    }

}