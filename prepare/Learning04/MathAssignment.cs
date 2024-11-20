class MathAssignment : Assignment{

    private string _textbookSection;
    private string _problems;
    public MathAssignment(string stutdentName, string topic, string textbookSection, string problems) : base(stutdentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}