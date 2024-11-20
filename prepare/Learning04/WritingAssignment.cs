class WritingAssignment : Assignment{

    private string _title;
    public WritingAssignment(string stutdentName, string topic, string title) : base(stutdentName, topic){
        _title = title;
    }


    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}