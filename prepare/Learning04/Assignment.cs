using System.Dynamic;

class Assignment{
    private string _studentName;
    private string _topic;
    
    public Assignment(string stutdentName, string topic){
        _studentName = stutdentName;
        _topic = topic;
    }

    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}